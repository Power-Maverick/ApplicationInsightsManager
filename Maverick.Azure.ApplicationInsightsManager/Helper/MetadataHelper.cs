using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Maverick.Azure.ApplicationInsightsManager.Helper
{
    public class MetadataHelper
    {
        /// <summary>
        /// Retrieve list of unmanaged and visible solutions
        /// </summary>
        /// <param name="orgService"></param>
        /// <returns></returns>
        public static EntityCollection RetrieveSolutions(IOrganizationService orgService)
        {
            QueryExpression querySolution = new QueryExpression
            {
                EntityName = "solution",
                ColumnSet = new ColumnSet(new string[] { "publisherid", "installedon", "version", "friendlyname", "uniquename", "description" }),
                Criteria = new FilterExpression()
            };

            querySolution.Criteria.AddCondition("ismanaged", ConditionOperator.Equal, false);
            querySolution.Criteria.AddCondition("isvisible", ConditionOperator.Equal, true);
            LinkEntity linkPublisher = querySolution.AddLink("publisher", "publisherid", "publisherid");
            linkPublisher.Columns = new ColumnSet("customizationprefix");
            linkPublisher.EntityAlias = "pub";

            return orgService.RetrieveMultiple(querySolution);
        }

        /// <summary>
        /// Retrieve list of entities
        /// </summary>
        /// <returns></returns>
        public static List<EntityMetadata> RetrieveEntities(IOrganizationService orgService, bool customOnly = false)
        {
            var entities = new List<EntityMetadata>();

            var request = new RetrieveAllEntitiesRequest
            {
                RetrieveAsIfPublished = true,
                EntityFilters = EntityFilters.Entity
            };

            var response = (RetrieveAllEntitiesResponse)orgService.Execute(request);


            foreach (var emd in response.EntityMetadata)
            {
                entities.Add(emd);
            }

            return entities;
        }

        /// <summary>
        /// Retrieve list of customizable, main & quick create form that are active
        /// </summary>
        /// <param name="orgService"></param>
        /// <returns></returns>
        public static List<Entity> GetAllForms(IOrganizationService orgService)
        {
            var qe = new QueryExpression("systemform")
            {
                ColumnSet = new ColumnSet(new[] { "name", "formxml", "objecttypecode", "type" }),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("type", ConditionOperator.In, new[] {2,7}),
                        new ConditionExpression("iscustomizable", ConditionOperator.Equal, true),
                        new ConditionExpression("formactivationstate", ConditionOperator.Equal, 1)
                    }
                }
            };

            return orgService.RetrieveMultiple(qe).Entities.ToList();
        }

        public static CreateResponse CreateWebResource(IOrganizationService orgService, string solutionUniqueName, string displayName, string schemaName, string prefix, string instrumentationKey, string githubLocation)
        {
            Entity webResource = new Entity("webresource");
            webResource.Attributes.Add("name", string.Format("{0}{1}", prefix, schemaName));
            webResource.Attributes.Add("displayname", displayName);
            webResource.Attributes.Add("content", FileHelper.GetEncodedFileContents(instrumentationKey, githubLocation));
            webResource.Attributes.Add("description", "Javascript to trace the client insights in Azure Application Insights.");
            webResource.Attributes.Add("webresourcetype", new OptionSetValue(3));// 3 = JScript

            // Using CreateRequest because we want to add an optional parameter
            CreateRequest request = new CreateRequest
            {
                Target = webResource
            };
            // Set the SolutionUniqueName optional parameter so the Web Resources will be created in the context of a specific solution.
            request.Parameters.Add("SolutionUniqueName", solutionUniqueName);

            CreateResponse response = (CreateResponse)orgService.Execute(request);

            return response;
        }

        public static void AddJavascriptLibraryToForm(IOrganizationService orgService, Guid formId, string formXml, string schemaName, string prefix)
        {
            var formDoc = new XmlDocument();
            formDoc.LoadXml(formXml);

            var formNode = formDoc.SelectSingleNode("form");
            if (formNode == null)
            {
                throw new Exception("Expected node \"formNode\" was not found");
            }

            var formLibrariesNode = formNode.SelectSingleNode("formLibraries");
            var eventLibrary = formNode.SelectSingleNode("events");
            if (formLibrariesNode == null)
            {
                formLibrariesNode = formDoc.CreateElement("formLibraries");
                formNode.AppendChild(formLibrariesNode);
            }
            if (eventLibrary == null)
            {
                eventLibrary = formDoc.CreateElement("events");
                formNode.AppendChild(eventLibrary);
            }

            var jscriptName = string.Format("{0}{1}", prefix, schemaName);

            if (jscriptName != null)
            {
                var libraryNode = formLibrariesNode.SelectSingleNode(string.Format("Library[@name = '{0}']", jscriptName));

                if (libraryNode != null)
                {
                    // Do nothing
                }
                else
                {
                    var nameAttribute = formDoc.CreateAttribute("name");
                    var libraryUniqueIdAttribute = formDoc.CreateAttribute("libraryUniqueId");

                    nameAttribute.Value = jscriptName;
                    libraryUniqueIdAttribute.Value = Guid.NewGuid().ToString("B");
                    libraryNode = formDoc.CreateElement("Library");

                    if (libraryNode.Attributes != null)
                    {
                        libraryNode.Attributes.Append(nameAttribute);
                        libraryNode.Attributes.Append(libraryUniqueIdAttribute);
                    }

                    if (formLibrariesNode.ChildNodes.Count > 0)
                    {
                        formLibrariesNode.InsertBefore(libraryNode, formLibrariesNode.FirstChild);
                    }
                    else
                    {
                        formLibrariesNode.AppendChild(libraryNode);
                    }
                }

                // Add onload event
                var loadEventNode = eventLibrary.SelectSingleNode("event[@name='onload']");
                if (loadEventNode == null)
                {
                    loadEventNode = formDoc.CreateElement("event");

                    var loadEventNameAttribute = formDoc.CreateAttribute("name");
                    var loadEventApplicationAttribute = formDoc.CreateAttribute("application");
                    var loadEventActiveAttribute = formDoc.CreateAttribute("active");
                    loadEventNameAttribute.Value = "onload";
                    loadEventApplicationAttribute.Value = "false";
                    loadEventActiveAttribute.Value = "false";
                    loadEventNode.Attributes.Append(loadEventNameAttribute);
                    loadEventNode.Attributes.Append(loadEventApplicationAttribute);
                    loadEventNode.Attributes.Append(loadEventActiveAttribute);

                    eventLibrary.AppendChild(loadEventNode);
                }

                var loadhandlersNode = loadEventNode.SelectSingleNode("Handlers");
                if (loadhandlersNode == null)
                {
                    loadhandlersNode = formDoc.CreateElement("Handlers");
                    loadEventNode.AppendChild(loadhandlersNode);
                }

                var loadfunctionNode = loadhandlersNode.SelectSingleNode("Handler[@functionName='LoadTelemetry']");
                if (loadfunctionNode != null)
                {
                    return;
                }

                var loadfunctionNameAttribute = formDoc.CreateAttribute("functionName");
                var loadlibraryNameAttribute = formDoc.CreateAttribute("libraryName");
                var loadhandlerUniqueIdAttribute = formDoc.CreateAttribute("handlerUniqueId");
                var loadenabledAttribute = formDoc.CreateAttribute("enabled");
                var loadparametersAttribute = formDoc.CreateAttribute("parameters");
                var loadpassExecutionContextAttribute = formDoc.CreateAttribute("passExecutionContext");

                loadfunctionNameAttribute.Value = "LoadTelemetry";
                loadlibraryNameAttribute.Value = jscriptName;
                loadhandlerUniqueIdAttribute.Value = Guid.NewGuid().ToString("B");
                loadenabledAttribute.Value = "true";
                loadparametersAttribute.Value = "";
                loadpassExecutionContextAttribute.Value = "true";

                loadfunctionNode = formDoc.CreateElement("Handler");
                loadfunctionNode.Attributes.Append(loadfunctionNameAttribute);
                loadfunctionNode.Attributes.Append(loadlibraryNameAttribute);
                loadfunctionNode.Attributes.Append(loadhandlerUniqueIdAttribute);
                loadfunctionNode.Attributes.Append(loadenabledAttribute);
                loadfunctionNode.Attributes.Append(loadparametersAttribute);
                loadfunctionNode.Attributes.Append(loadpassExecutionContextAttribute);
                loadhandlersNode.AppendChild(loadfunctionNode);

            }


            Entity systemForm = new Entity("systemform", formId);
            systemForm["formxml"] = formDoc.OuterXml;
            orgService.Update(systemForm);

            //PublishSystemForm(service);
        }

        public static void PublishSystemForm(IOrganizationService service)
        {
            var request = new PublishXmlRequest
            {
                ParameterXml = String.Format("<importexportxml><entities><entity>systemform</entity></entities></importexportxml>")
            };
            service.Execute(request);


            var publishAllRequest = new PublishAllXmlRequest();
            service.Execute(publishAllRequest);
        }
    }
}
