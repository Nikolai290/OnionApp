using OnionApp.Domain.Core.DbEntities;


namespace OnionApp.Dto.Employee {
    public class RoleDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleDto(Role role) {
            Id = role.Id;
            Name = role.Name;
        }
    }
}
