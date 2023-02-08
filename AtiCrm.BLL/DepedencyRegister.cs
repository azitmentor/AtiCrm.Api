using AtiCrm.BLL.Interfaces;
using AtiCrm.BLL.Managers;
using AtiCrm.Datalayer.Dataproviders;
using AtiCrm.Datalayer.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtiCrm.BLL
{
    public class DepencyRegister
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IPartnerManager, PartnerManager>();
        }
    }
}
