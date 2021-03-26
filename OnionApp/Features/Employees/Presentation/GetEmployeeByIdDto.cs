using OnionApp.Domain.Core.DbEntities;
using System.Collections.Generic;
using System.Linq;

namespace OnionApp.Features.Employees.Presentation {
    public class GetEmployeeByIdDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int PromocodesCount { get; set; }
        public IList<PromocodeDto> Promocodes { get; set; }
        public IList<RoleDto> RolesList { get; set; }
        
        public GetEmployeeByIdDto(Domain.Core.DbEntities.Employee employee, IEnumerable<Role> roles) {
            Id = employee.Id;
            Name = employee.Name;
            RoleId = employee.Role.Id;
            PromocodesCount = employee.Promocodes.Count;
            Promocodes = employee.Promocodes.Select(x => new PromocodeDto(x)).ToList();
            RolesList = roles.Select(x => new RoleDto(x)).ToList();
        }
    }
}
