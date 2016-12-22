using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lws.Web.Models
{
    public class ValuesSearchFilterModel
    {
        public bool LastValue { get; set; }
        public DateTime DayFrom { get; set; }
        public DateTime DayTo { get; set; }
        public string Ssn { get; set; }
        public PageSettingsModel Page { get; set; }
    }
}