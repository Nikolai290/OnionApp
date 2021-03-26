using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionApp.Domain.Interfaces.Abstractions.Repositories {
    public interface IUnitOfWork : IDisposable {
    }

    public interface IUnitOfWork<TSession> : IUnitOfWork where TSession : ISession {
        TSession Session { get; }
    }
}
