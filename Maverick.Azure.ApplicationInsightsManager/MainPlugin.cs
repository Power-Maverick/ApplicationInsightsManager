using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Maverick.Azure.ApplicationInsightsManager
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Application Insights Manager"),
        ExportMetadata("Description", "Create application insight web resource. Add or remove application insight web resource on Entity Form."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "White"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MainPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MainPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MainPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}