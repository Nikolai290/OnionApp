using OnionApp.Domain.Core.DbEntities;


namespace OnionApp.Features.Employees.Presentation {
    public class RoleDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleDto(Role role) {
            Id = role.Id;
            Name = role.Name;
        }
    }
}
