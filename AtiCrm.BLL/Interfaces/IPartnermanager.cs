using AtiCrm.Datalayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.BLL.Interfaces
{
    public interface IPartnerManager
    {
        IEnumerable<t_partner> GetPartnerList();
        IEnumerable<t_partner_event> GetPartnerEvents(int partnerId);
        bool Save(t_partner partner);
        t_partner GetPartner(int partnerid);
    }
}
