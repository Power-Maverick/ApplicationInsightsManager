using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Azure.ApplicationInsightsManager
{
    public sealed class ComboListItem
    {
        public string DisplayText { get; set; }
        public Entity MetaData { get; set; }
    }
}
