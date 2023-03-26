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

        public t_partner GetPartner(int partnerid)
        {
            return _context.t_partner.FirstOrDefault(p => p.id == partnerid);
        }

        public IEnumerable<t_partner> GetPartnerData()
        {
            return _context.t_partner.ToList();
        }

        public IEnumerable<t_partner_event> GetPartnerEvents(int partnerid)
        {
            return _context.t_partner_event.Where(p => p.t_partner.id == partnerid);
        }

        public bool Save(t_partner partner)
        {
            if (partner.id > 0)
            {
                _context.t_partner.Update(partner);
            }
            else
            {
                _context.t_partner.Add(partner);
            }
            _context.SaveChanges();
            return true;
        }
    }
}
