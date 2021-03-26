using FluentNHibernate.Mapping;
using OnionApp.Domain.Core.DbEntities;

namespace OnionApp.Infrastructure.Data.Nhibernate.Mapping {
    class EmployeeMapping : ClassMap<Employee> {
        public EmployeeMapping() {
            Id(x => x.Id);
            Map(x => x.IsDeleted);
            Map(x => x.Name);
            References(x => x.Role);
            HasManyToMany(x => x.Promocodes);
        }
    }
}
