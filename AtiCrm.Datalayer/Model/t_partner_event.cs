using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.Datalayer.Model
{
    public class t_partner_event
    {
        public int id { get; set; }
        public DateTime eventdate { get; set; }
        public string comment { get; set; }
        public t_partner t_partner { get; set; }
    }
}
