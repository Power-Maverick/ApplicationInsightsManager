using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maverick.Azure.ApplicationInsightsManager
{
    public sealed class DataGridViewListItem
    {
        public Guid FormId { get; set; }
        public string EntityName { get; set; }
        public string FormName { get; set; }
        public string FormType { get; set; }
        public bool doesAiExists { get; set; }
    }
}
