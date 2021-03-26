using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using System;

namespace OnionApp.Domain.Interfaces.Abstractions.Repositories {
    public interface IUnitOfWork : IDisposable {
    }

    public interface IUnitOfWork<TSession> : IUnitOfWork where TSession : ISession {
        TSession Session { get; }
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity;
    }
}
