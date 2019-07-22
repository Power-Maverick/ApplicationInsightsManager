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
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAABlVBMVEVHcEwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAi/YlRAAAAhnRSTlMAHAf1/AID+/r+8gYR6rnGSenjqR5Ftuz3r+Xmj5Br8B2o3Kyq6zszQsUqT4glSHhG35GiOWwndHukR2kop3kfd1u3+dZxWe6a83Kw2j08Mv21UFEF9iuHBIl8OD5qFhWl6BjxXBdelasxXZIpQa20VpgTlrND7dgS1xtE2512Upy4MC+LOoMURTUAAAHUSURBVDjLvVNXWxtBDJTt8xXfnbExtnHFBhcgpoRQQw8BEnoLJaEkIb33Xkib3x3tOf7CHjyjh9Psp9mTNNISnZ35Q5mevrsC3e7ryYT87ri3ADbt9YdXLxWBIl4X4TrCA8PPpjA7i6mW4QEbY3JcjaPEbuQjcLmfwSJsOckImoWbXAGUGYHOo0MihBDjb1TDtzForQyD6JYIF3GpPFfQ0ahpjdAjc+UgohLhETRIpuHOsXBD3gAW2mD/sra3rZ9xtC0AxmiuFi8V4buK1gDOVc9rCEQR8CHc++/+Id58OkIdEuT9nUrtmJTgwxXPKpo8DmEIBZXWYSjttCPSV2hTMfhvagsuOIR6NLDU17BKlMKfJSSJfsBnEo2jXiLEBKG0KAhBiTCEByp9d1JURIot2lwxsPY/Ra4Jzz1fnSLNSjK5ZdK8U2SsViT1huU21xH4LNq8daMmRG6UhfpSh+KytbFhlVmoZhbqpueYlvdOSj3pHtbydISHpes8rPz0Q/ewquN+q2FiEPrTU8bdX12YGd5H5cVpC6MWscSu/T2v3BMGuwi79noQ9kR2Xse7OPREtstGl3vtI6J2/bFl3Xf6yZsnHk5nOr13INB+NpPu9J/hm/0LadCIfBQjWdEAAAAASUVORK5CYII="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Gray"),
        ExportMetadata("PrimaryFontColor", "White"),
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