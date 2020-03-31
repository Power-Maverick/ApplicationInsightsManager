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

        public static CreateResponse CreateWebResource(IOrganizationService orgService, string solutionUniqueName, string displayName, string schemaName, string prefix, string instrumentationKey)
        {
            /*
            // AI.Init file creation
            const string AI_INIT_JS = "AI.Init.js";
            // Check if AI.Init.js already exists
            Guid aiWebResourceId = Guid.Empty;
            QueryExpression qeAiWr = new QueryExpression("webresource");
            qeAiWr.Criteria.AddCondition("name", ConditionOperator.Equal, string.Format("{0}{1}", prefix, AI_INIT_JS));
            EntityCollection ecAiWr = orgService.RetrieveMultiple(qeAiWr);
            if (ecAiWr != null && ecAiWr.Entities != null && ecAiWr.Entities.Count > 0)
            {
                aiWebResourceId = ecAiWr.Entities[0].Id;
            }

            // Create only if AI.Init.js does not exists
            if (aiWebResourceId == Guid.Empty)
            {
                // Create AI.Init.js file
                Entity aiWebResource = new Entity("webresource");
                aiWebResource.Attributes.Add("name", string.Format("{0}{1}", prefix, AI_INIT_JS));
                aiWebResource.Attributes.Add("displayname", AI_INIT_JS);
                aiWebResource.Attributes.Add("content", FileHelper.GetAiInitFileContents(instrumentationKey));
                aiWebResource.Attributes.Add("description", "Azure Application Insights initializer script.");
                aiWebResource.Attributes.Add("webresourcetype", new OptionSetValue(3));// 3 = JScript

                // Using CreateRequest because we want to add an optional parameter
                CreateRequest aiRequest = new CreateRequest
                {
                    Target = aiWebResource
                };
                // Set the SolutionUniqueName optional parameter so the Web Resources will be created in the context of a specific solution.
                aiRequest.Parameters.Add("SolutionUniqueName", solutionUniqueName);

                CreateResponse aiResponse = (CreateResponse)orgService.Execute(aiRequest);
                aiWebResourceId = aiResponse.id;
            }
            */

            // AI.Default file creation
            const string AI_DEFAULT_JS = "AI.Default.js";
            // Check if AI.Default.js already exists
            Guid aiDefaultWebResourceId = Guid.Empty;
            QueryExpression qeAiDefaultWr = new QueryExpression("webresource");
            qeAiDefaultWr.Criteria.AddCondition("name", ConditionOperator.Equal, string.Format("{0}{1}", prefix, AI_DEFAULT_JS));
            EntityCollection ecAiDefaultWr = orgService.RetrieveMultiple(qeAiDefaultWr);
            if (ecAiDefaultWr != null && ecAiDefaultWr.Entities != null && ecAiDefaultWr.Entities.Count > 0)
            {
                aiDefaultWebResourceId = ecAiDefaultWr.Entities[0].Id;
            }

            // Create only if AI.Default.js does not exists
            if (aiDefaultWebResourceId == Guid.Empty)
            {
                // Create AI.Default.js file
                Entity aiWebResource = new Entity("webresource");
                aiWebResource.Attributes.Add("name", string.Format("{0}{1}", prefix, AI_DEFAULT_JS));
                aiWebResource.Attributes.Add("displayname", AI_DEFAULT_JS);
                aiWebResource.Attributes.Add("content", FileHelper.GetAiDefaultFileContents(instrumentationKey));
                aiWebResource.Attributes.Add("description", "Azure Application Insights Default script.");
                aiWebResource.Attributes.Add("webresourcetype", new OptionSetValue(3));// 3 = JScript

                // Using CreateRequest because we want to add an optional parameter
                CreateRequest aiRequest = new CreateRequest
                {
                    Target = aiWebResource
                };
                // Set the SolutionUniqueName optional parameter so the Web Resources will be created in the context of a specific solution.
                aiRequest.Parameters.Add("SolutionUniqueName", solutionUniqueName);

                CreateResponse aiResponse = (CreateResponse)orgService.Execute(aiRequest);
                aiDefaultWebResourceId = aiResponse.id;
            }

            // Create D365Insights.js file
            //var d365InsightsDependencyXml = @"<Dependencies><Dependency componentType=""WebResource""><Library name=""" + string.Format("{0}{1}", prefix, AI_INIT_JS) + @""" displayName=""" + AI_INIT_JS + @""" languagecode="""" description=""Azure Application Insights initializer script."" libraryUniqueId=""{" + aiWebResourceId + @"}""/></Dependency></Dependencies>";

            Entity d365InsightsWebResource = new Entity("webresource");
            d365InsightsWebResource.Attributes.Add("name", string.Format("{0}{1}", prefix, schemaName));
            d365InsightsWebResource.Attributes.Add("displayname", displayName);
            d365InsightsWebResource.Attributes.Add("content", FileHelper.GetD365InsightsFileContents(instrumentationKey));
            d365InsightsWebResource.Attributes.Add("description", "Javascript to trace the client insights in Azure Application Insights.");
            d365InsightsWebResource.Attributes.Add("webresourcetype", new OptionSetValue(3));// 3 = JScript
            //d365InsightsWebResource.Attributes.Add("dependencyxml", d365InsightsDependencyXml);

            // Using CreateRequest because we want to add an optional parameter
            CreateRequest d365InsightsRequest = new CreateRequest
            {
                Target = d365InsightsWebResource
            };
            // Set the SolutionUniqueName optional parameter so the Web Resources will be created in the context of a specific solution.
            d365InsightsRequest.Parameters.Add("SolutionUniqueName", solutionUniqueName);

            CreateResponse d365InsightsResponse = (CreateResponse)orgService.Execute(d365InsightsRequest);

            return d365InsightsResponse;
        }

        public static void AddJavascriptLibraryToForm(IOrganizationService orgService, Guid formId, string formXml, string prefix, string jscriptName, AppInsightsConfigs config)
        {
            XmlDocument formDoc = XmlHelper.GetModifiedFormXml(formXml,prefix, jscriptName, config);

            Entity systemForm = new Entity("systemform", formId);
            systemForm["formxml"] = formDoc.OuterXml;
            orgService.Update(systemForm);

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

        public static List<Entity> GetWebResources(IOrganizationService orgService)
        {
            var qe = new QueryExpression("webresource")
            {
                ColumnSet = new ColumnSet(new[] { "content", "name", "displayname", "webresourceid" }),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("webresourcetype", ConditionOperator.Equal, 3), // script only
                        new ConditionExpression("iscustomizable", ConditionOperator.Equal, true)
                    }
                }
            };

            return orgService.RetrieveMultiple(qe).Entities.ToList();
        }
    }
}
