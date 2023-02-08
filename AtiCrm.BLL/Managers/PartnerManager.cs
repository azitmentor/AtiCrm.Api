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

        public IEnumerable<t_partner> GetPartnerList()
        {
            return _dataprovider.GetPartnerData();
        }
    }
}
