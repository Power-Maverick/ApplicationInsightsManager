using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Azure.ApplicationInsightsManager
{
    public sealed class ExistingWebResource
    {
        public Guid WebResourceId { get; set; }
        public string Contents { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }

    }
}
