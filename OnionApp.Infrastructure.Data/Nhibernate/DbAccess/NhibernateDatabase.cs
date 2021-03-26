using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace OnionApp.Infrastructure.Data.Nhibernate.DbAccess {
    public class NhibernateDatabase  {
        private readonly ISessionFactory sessionFactory;

        public NhibernateDatabase() { }


    }
}
