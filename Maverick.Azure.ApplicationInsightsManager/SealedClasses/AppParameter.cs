using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Azure.ApplicationInsightsManager.SealedClasses
{
    public sealed class AppParameter
    {
        public string prefix { get; set; }
        public string jscript { get; set; }
    }
}
