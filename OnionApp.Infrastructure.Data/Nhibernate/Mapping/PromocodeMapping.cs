using FluentNHibernate.Mapping;
using OnionApp.Domain.Core.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionApp.Infrastructure.Data.Nhibernate.Mapping {
    class PromocodeMapping : ClassMap<Promocode> {

        public PromocodeMapping() {
            Id(x => x.Id);
            Map(x => x.IsDeleted);
            Map(x => x.Code);
            Map(x => x.Description);
            References(x => x.Preference);
            References(x => x.Partner);
            HasManyToMany(x => x.Employee);
            HasManyToMany(x => x.Customers);
        }

    }
}
