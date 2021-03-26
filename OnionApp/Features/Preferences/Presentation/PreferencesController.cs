using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Features.Preferences.Presentation {
    [Route("[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase {

        // TODO: implement other actions in PreferencesController

        [HttpGet]
        public async Task GetAllPreferencesAsync() {

        }

        [HttpGet("{id:int:min(1)}")]
        public async Task GetPreferenceByIdAsync() {

        }
    }
}
