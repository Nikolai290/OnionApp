using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Features.Promocodes.Presentation {
    [Route("[controller]")]
    [ApiController]
    public class PromocodesController : ControllerBase {

        // TODO: implement other actions in PromocodesController

        [HttpGet]
        public async Task GetAllPromocodesAsync() {

        }

        [HttpPost]
        public async Task GetPromocodeByIdAsync() { }
    }
}
