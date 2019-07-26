using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Azure.ApplicationInsightsManager
{
    public sealed class AppInsightsConfigs
    {
        public bool disablePageviewTracking { get; set; }
        public bool disablePageLoadTimeTracking { get; set; }
        public bool disableExceptionTracking { get; set; }
        public bool disableAjaxTracking { get; set; }
        public bool disableTraceTracking { get; set; }
        public bool disableDependencyTracking { get; set; }
        public bool disableMetricTracking { get; set; }
        public bool disableEventTracking { get; set; }
    }
}
