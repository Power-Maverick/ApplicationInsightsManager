using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Azure.ApplicationInsightsManager.Helper
{
    public class FileHelper
    {
        private const string D365Insights_JS_FILE_LOCATION = "\\script\\D365Insights.js";
        private const string AI_Init_JS_FILE_LOCATION = "\\script\\AI.Init.js";
        private const string AI_Default_JS_FILE_LOCATION = "\\script\\AI.Default.js";

        /// <summary>
        /// Gets the encoded contents for D365Insights.js file
        /// </summary>
        /// <returns></returns>
        static public string GetD365InsightsFileContents(string instrumentationKey)
        {
            string scriptString = string.Empty;

            var fullPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "\\" + D365Insights_JS_FILE_LOCATION;

            if (File.Exists(fullPath))
            {
                using (TextReader tr = new StreamReader(fullPath))
                {
                    scriptString = tr.ReadToEnd();
                    scriptString = scriptString.Replace("AIInstrumentationKeyForReplace", instrumentationKey);
                }
            }

            return Base64Encode(scriptString);
        }

        /// <summary>
        /// Gets the encoded contents for AI.Init.js file
        /// </summary>
        /// <returns></returns>
        static public string GetAiInitFileContents(string instrumentationKey)
        {
            string scriptString = string.Empty;

            var fullPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "\\" + AI_Init_JS_FILE_LOCATION;

            if (File.Exists(fullPath))
            {
                using (TextReader tr = new StreamReader(fullPath))
                {
                    scriptString = tr.ReadToEnd();
                    scriptString = scriptString.Replace("AIInstrumentationKeyForReplace", instrumentationKey);
                }
            }

            return Base64Encode(scriptString);
        }

        /// <summary>
        /// Gets the encoded contents for AI.Default.js file
        /// </summary>
        /// <returns></returns>
        static public string GetAiDefaultFileContents(string instrumentationKey)
        {
            string scriptString = string.Empty;

            var fullPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "\\" + AI_Default_JS_FILE_LOCATION;

            if (File.Exists(fullPath))
            {
                using (TextReader tr = new StreamReader(fullPath))
                {
                    scriptString = tr.ReadToEnd();
                    scriptString = scriptString.Replace("AIInstrumentationKeyForReplace", instrumentationKey);
                }
            }

            return Base64Encode(scriptString);
        }

        /// <summary>
        /// Decodes the Web Resource File content
        /// </summary>
        /// <returns></returns>
        static public string GetDecodedFileContents(string encodedString)
        {
            if (string.IsNullOrEmpty(encodedString))
            {
                return string.Empty;
            }

            var base64Decoded = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(encodedString));

            return base64Decoded;
        }

        private static string Base64Encode(string plainText)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainText));
        }
    }
}
