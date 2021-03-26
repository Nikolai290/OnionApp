using FluentNHibernate.Mapping;
using OnionApp.Domain.Core.DbEntities;

namespace OnionApp.Infrastructure.Data.Nhibernate.Mapping {
    class CustomerMapping : ClassMap<Customer> {
        public CustomerMapping() {
            Id(x => x.Id);
            Map(x => x.IsDeleted);
            Map(x => x.Name);
            Map(x => x.Phone);
            Map(x => x.Email);
            References(x => x.Preferences);
            HasManyToMany(x => x.Promocodes);
        }
    }
}
