using AtiCrm.Datalayer.Interfaces;
using AtiCrm.Datalayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.Datalayer.Dataproviders
{
    public class PartnerDataprovider : IPartnerDataprovider
    {
        private readonly CrmDbContext _context;

        public PartnerDataprovider(CrmDbContext context)
        {
            _context = context;
        }

        public IEnumerable<t_partner> GetPartnerData()
        {
            return _context.t_partner.ToList();
        }

        public IEnumerable<t_partner_event> GetPartnerEvents(int partnerid)
        {
            return _context.t_partner_event.Where(p => p.t_partner.id == partnerid);
        }
    }
}
