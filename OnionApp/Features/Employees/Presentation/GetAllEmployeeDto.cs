using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Features.Employees.Presentation {
    public class GetAllEmployeeDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
    }
}
