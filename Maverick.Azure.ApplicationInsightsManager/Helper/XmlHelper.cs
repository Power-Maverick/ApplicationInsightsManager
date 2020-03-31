using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Maverick.Azure.ApplicationInsightsManager.Helper
{
    public class XmlHelper
    {
        #region Constants

        private const string D365Insights_LOAD_FUNCTION_NAME = "D365AppInsights.startLogging";
        private const string D365Insights_SAVE_FUNCTION_NAME = "D365AppInsights.trackSaveTime";

        private const string AI_Default_JS_FILE_NAME = "AI.Default.js";

        #endregion

        public static XmlDocument GetModifiedFormXml(string formXml, string prefix, string jscriptName, AppInsightsConfigs config)
        {
            string D365Insights_CONFIG_PARAMS = @"{    
	                ""enableDebug"": true,  
                    ""disablePageviewTracking"": " + config.disablePageviewTracking.ToString().ToLower() + @",  
	                ""percentLoggedPageview"": 100,  
	                ""disablePageLoadTimeTracking"": " + config.disablePageLoadTimeTracking.ToString().ToLower() + @",  
	                ""percentLoggedPageLoadTime"": 100,  
	                ""disableExceptionTracking"": " + config.disableExceptionTracking.ToString().ToLower() + @",   
	                ""percentLoggedException"": 100,  
	                ""disableAjaxTracking"": " + config.disableAjaxTracking.ToString().ToLower() + @",  
	                ""maxAjaxCallsPerView"": 500,  
	                ""disableTraceTracking"": " + config.disableTraceTracking.ToString().ToLower() + @",   
	                ""percentLoggedTrace"": 100,  
	                ""disableDependencyTracking"": " + config.disableDependencyTracking.ToString().ToLower() + @",   
	                ""percentLoggedDependency"": 100,  
	                ""disableMetricTracking"": " + config.disableMetricTracking.ToString().ToLower() + @",   
	                ""percentLoggedMetric"": 100,  
	                ""disableEventTracking"": " + config.disableEventTracking.ToString().ToLower() + @",   
	                ""percentLoggedEvent"": 100,
                    ""disablePageSaveTimeTracking"": " + config.disablePageSaveTimeTracking.ToString().ToLower() + @",   
	                ""percentLoggedPageSaveTime"": 100
                    }";

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

            if (jscriptName != null)
            {
                //var jscriptName = string.Format("{0}{1}", prefix, schemaName);
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

                var loadfunctionNode = loadhandlersNode.SelectSingleNode("Handler[@functionName='" + D365Insights_LOAD_FUNCTION_NAME + "']");
                // Add the function only if it does not already exists
                if (loadfunctionNode == null)
                {
                    var loadfunctionNameAttribute = formDoc.CreateAttribute("functionName");
                    var loadlibraryNameAttribute = formDoc.CreateAttribute("libraryName");
                    var loadhandlerUniqueIdAttribute = formDoc.CreateAttribute("handlerUniqueId");
                    var loadenabledAttribute = formDoc.CreateAttribute("enabled");
                    var loadparametersAttribute = formDoc.CreateAttribute("parameters");
                    var loadpassExecutionContextAttribute = formDoc.CreateAttribute("passExecutionContext");

                    loadfunctionNameAttribute.Value = D365Insights_LOAD_FUNCTION_NAME;
                    loadlibraryNameAttribute.Value = jscriptName;
                    loadhandlerUniqueIdAttribute.Value = Guid.NewGuid().ToString("B");
                    loadenabledAttribute.Value = "true";
                    loadparametersAttribute.Value = D365Insights_CONFIG_PARAMS;
                    loadpassExecutionContextAttribute.Value = "true";

                    loadfunctionNode = formDoc.CreateElement("Handler");
                    loadfunctionNode.Attributes.Append(loadfunctionNameAttribute);
                    loadfunctionNode.Attributes.Append(loadlibraryNameAttribute);
                    loadfunctionNode.Attributes.Append(loadhandlerUniqueIdAttribute);
                    loadfunctionNode.Attributes.Append(loadenabledAttribute);
                    loadfunctionNode.Attributes.Append(loadparametersAttribute);
                    loadfunctionNode.Attributes.Append(loadpassExecutionContextAttribute);
                    //loadhandlersNode.AppendChild(loadfunctionNode);

                    if (loadhandlersNode.ChildNodes.Count > 0)
                    {
                        loadhandlersNode.InsertBefore(loadfunctionNode, loadhandlersNode.FirstChild);
                    }
                    else
                    {
                        loadhandlersNode.AppendChild(loadfunctionNode);
                    }
                }

                // Add onsave event
                var saveEventNode = eventLibrary.SelectSingleNode("event[@name='onsave']");
                if (saveEventNode == null)
                {
                    saveEventNode = formDoc.CreateElement("event");

                    var saveEventNameAttribute = formDoc.CreateAttribute("name");
                    var saveEventApplicationAttribute = formDoc.CreateAttribute("application");
                    var saveEventActiveAttribute = formDoc.CreateAttribute("active");
                    saveEventNameAttribute.Value = "onsave";
                    saveEventApplicationAttribute.Value = "false";
                    saveEventActiveAttribute.Value = "false";
                    saveEventNode.Attributes.Append(saveEventNameAttribute);
                    saveEventNode.Attributes.Append(saveEventApplicationAttribute);
                    saveEventNode.Attributes.Append(saveEventActiveAttribute);

                    eventLibrary.AppendChild(saveEventNode);
                }

                var savehandlersNode = saveEventNode.SelectSingleNode("Handlers");
                if (savehandlersNode == null)
                {
                    savehandlersNode = formDoc.CreateElement("Handlers");
                    saveEventNode.AppendChild(savehandlersNode);
                }

                var savefunctionNode = savehandlersNode.SelectSingleNode("Handler[@functionName='" + D365Insights_SAVE_FUNCTION_NAME + "']");
                // Add the function only if it does not already exists
                if (savefunctionNode == null)
                {
                    var functionNameAttribute = formDoc.CreateAttribute("functionName");
                    var libraryNameAttribute = formDoc.CreateAttribute("libraryName");
                    var handlerUniqueIdAttribute = formDoc.CreateAttribute("handlerUniqueId");
                    var enabledAttribute = formDoc.CreateAttribute("enabled");
                    var parametersAttribute = formDoc.CreateAttribute("parameters");
                    var passExecutionContextAttribute = formDoc.CreateAttribute("passExecutionContext");

                    functionNameAttribute.Value = D365Insights_SAVE_FUNCTION_NAME;
                    libraryNameAttribute.Value = jscriptName;
                    handlerUniqueIdAttribute.Value = Guid.NewGuid().ToString("B");
                    enabledAttribute.Value = "true";
                    parametersAttribute.Value = "";
                    passExecutionContextAttribute.Value = "true";

                    savefunctionNode = formDoc.CreateElement("Handler");
                    savefunctionNode.Attributes.Append(functionNameAttribute);
                    savefunctionNode.Attributes.Append(libraryNameAttribute);
                    savefunctionNode.Attributes.Append(handlerUniqueIdAttribute);
                    savefunctionNode.Attributes.Append(enabledAttribute);
                    savefunctionNode.Attributes.Append(parametersAttribute);
                    savefunctionNode.Attributes.Append(passExecutionContextAttribute);
                    //savehandlersNode.AppendChild(savefunctionNode);

                    if (savehandlersNode.ChildNodes.Count > 0)
                    {
                        savehandlersNode.InsertBefore(savefunctionNode, savehandlersNode.FirstChild);
                    }
                    else
                    {
                        savehandlersNode.AppendChild(savefunctionNode);
                    }
                }
            }

            // Add Ai.Default script to Form
            var jscriptAiDefaultName = string.Format("{0}{1}", prefix, AI_Default_JS_FILE_NAME);
            var libraryAiDefaultNode = formLibrariesNode.SelectSingleNode(string.Format("Library[@name = '{0}']", jscriptAiDefaultName));
            if (libraryAiDefaultNode != null)
            {
                // Do nothing
            }
            else
            {
                var nameAiDefaultAttribute = formDoc.CreateAttribute("name");
                var libraryAiDefaultUniqueIdAttribute = formDoc.CreateAttribute("libraryUniqueId");

                nameAiDefaultAttribute.Value = jscriptAiDefaultName;
                libraryAiDefaultUniqueIdAttribute.Value = Guid.NewGuid().ToString("B");
                libraryAiDefaultNode = formDoc.CreateElement("Library");

                if (libraryAiDefaultNode.Attributes != null)
                {
                    libraryAiDefaultNode.Attributes.Append(nameAiDefaultAttribute);
                    libraryAiDefaultNode.Attributes.Append(libraryAiDefaultUniqueIdAttribute);
                }

                if (formLibrariesNode.ChildNodes.Count > 0)
                {
                    formLibrariesNode.InsertBefore(libraryAiDefaultNode, formLibrariesNode.FirstChild);
                }
                else
                {
                    formLibrariesNode.AppendChild(libraryAiDefaultNode);
                }
            }

            return formDoc;
        }
    }
}
