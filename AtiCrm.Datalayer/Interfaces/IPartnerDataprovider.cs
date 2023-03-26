using AtiCrm.Datalayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.Datalayer.Interfaces
{
    public interface IPartnerDataprovider
    {
        IEnumerable<t_partner> GetPartnerData();
        IEnumerable<t_partner_event> GetPartnerEvents(int partnerid);
        bool Save(t_partner partner);
        t_partner GetPartner(int partnerid);
    }
}
