using FluentNHibernate.Mapping;
using OnionApp.Domain.Core.DbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionApp.Infrastructure.Data.Nhibernate.Mapping {
    class PreferenceMapping : ClassMap<Preference> {
        public PreferenceMapping() {
            Id(x => x.Id);
            Map(x => x.IsDeleted);
            Map(x => x.Name);
            HasManyToMany(x => x.Customers);
            HasManyToMany(x => x.Promocodes);
        }

    }
}
