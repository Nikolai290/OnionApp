using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Features.Partners.Presentation {
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersController : ControllerBase {

        // TODO: implement other actions in PartnersController

        [HttpGet]
        public async Task GetAllPartnersAsync() { }

        [HttpGet("{id:int:min(1)}")]
        public async Task GetPartnerByIdAsync() { }

        [HttpGet("{id:int:min(1)}/limits")]
        public async Task GetPartnerLimitsAsync() { }

        [HttpPost("{id:int:min(1)}/cancelledLimits")]
        public async Task PostPartnerCancelledLimitsAsync() { }
    }
}
