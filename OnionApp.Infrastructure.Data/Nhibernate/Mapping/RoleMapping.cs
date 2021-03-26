using FluentNHibernate.Mapping;
using OnionApp.Domain.Core.DbEntities;

namespace OnionApp.Infrastructure.Data.Nhibernate.Mapping {
    class RoleMapping : ClassMap<Role> {

        public RoleMapping() {
            Id(x => x.Id);
            Map(x => x.IsDeleted);
            Map(x => x.Name);
            HasMany(x => x.Employees);
        }


    }
}
