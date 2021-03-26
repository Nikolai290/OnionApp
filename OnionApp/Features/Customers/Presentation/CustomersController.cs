using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Features.Customers.Presentation {
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase {

        // TODO: implement other actions in CustomersController

        [HttpGet]
        public async Task<IList<GetAllCustomerDto>> GetAllCustomerAsync() {

            return new List<GetAllCustomerDto>();
        }

        [HttpGet("{id:int:min(1)}")]
        public async Task<GetCustomerByIdDto> GetAllCustomerByIdAsync(int id) {

            return new GetCustomerByIdDto();
        }

        [HttpGet("{id:int:min(1)}/promocodes")]
        public async Task GetCustomersPromocodes(int id) {

        }

        [HttpPost]
        public async Task CreateCustomerAsync(object model) {

        }

        [HttpPut]
        public async Task UpdateCustomerAsync(object model) {

        }

        [HttpDelete("{id:int:min(1)}")]
        public async Task DeleteCustomerAsync(int id) {

        }
    }
}
