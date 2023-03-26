using AtiCrm.BLL.Interfaces;
using AtiCrm.Datalayer;
using AtiCrm.Datalayer.Interfaces;
using AtiCrm.Datalayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.BLL.Managers
{
    public class PartnerManager : IPartnerManager
    {
        private readonly IPartnerDataprovider _dataprovider;

        public PartnerManager(IPartnerDataprovider dataprovider)
        {
            _dataprovider = dataprovider;
        }

        public t_partner GetPartner(int partnerid)
        {
            if (partnerid == 0)
            {
                return new t_partner();
            }
            return _dataprovider.GetPartner(partnerid);
        }

        public IEnumerable<t_partner_event> GetPartnerEvents(int partnerId)
        {
            return _dataprovider.GetPartnerEvents(partnerId);
        }

        public IEnumerable<t_partner> GetPartnerList()
        {
            return _dataprovider.GetPartnerData();
        }

        public bool Save(t_partner partner)
        {
            return _dataprovider.Save(partner);
        }
    }
}
