using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;
using System;
using System.Collections.Generic;

namespace OnionApp.Infrastructure.Data.Repositories {
    public class UnitOfWork<TSession> : IUnitOfWork<TSession>, IUnitOfWork where TSession : ISession {

        private bool disposed = false;

        private Dictionary<Type, object> repositories;


        public TSession Session;

        public UnitOfWork(ISession session) {
            Session = (TSession)session;
        }

        TSession IUnitOfWork<TSession>.Session => throw new NotImplementedException();

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    Session.Dispose();
                }
                disposed = true;
            }
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity {
            if (repositories == null)
                repositories = new Dictionary<Type, object>();
            var type = typeof(TEntity);
            if (!repositories.ContainsKey(type))
                repositories[type] = new BaseRepository<TEntity>(Session);
            return (IRepository<TEntity>)repositories[type];
        }
    }
}
