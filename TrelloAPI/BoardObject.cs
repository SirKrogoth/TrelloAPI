using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloAPI
{
    public class BoardObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string descData { get; set; }
        public bool closed { get; set; } = false;
        public string idOrganization { get; set; }
        public bool pinned { get; set; } = false;
        public string url { get; set; }
        public string shortUrl { get; set; }
        public object prefs { get; set; }
        public object labelNames { get; set; }
        public bool started
        {
            get
            {
                return started;
            }
            set
            {
                if (string.IsNullOrEmpty(started.ToString()))
                    started = true;
            }
        }
        public object limits { get; set; }
        //public Array[] memberships { get; set; }
    }
}
