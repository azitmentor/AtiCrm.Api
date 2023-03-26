using AtiCrm.BLL.Interfaces;
using AtiCrm.Datalayer.Interfaces;
using AtiCrm.Datalayer.Model;
using Microsoft.AspNetCore.Mvc;

namespace aticrm.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartnerController : ControllerBase
    {
        private readonly ILogger<PartnerController> _logger;
        private readonly IPartnerManager _manager;

        public PartnerController(ILogger<PartnerController> logger, IPartnerManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        [HttpGet()]
        public IEnumerable<t_partner> Get()
        {
            return _manager.GetPartnerList();
        }

        [HttpGet("{id}")]
        public t_partner Get(int id)
        {
            return _manager.GetPartner(id);
        }

        [HttpGet("events/{id}")]
        public IEnumerable<t_partner_event> GetPartnerEvents(int id)
        {
            return _manager.GetPartnerEvents(id);
        }

        [HttpPost("save")]
        public bool Save(t_partner partner)
        {
            return _manager.Save(partner);
        }
    }
}