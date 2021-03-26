using OnionApp.Domain.Core.DbEntities;
using System;

namespace OnionApp.Domain.Interfaces.Abstractions.Repositories {
    public interface IPromocodeRepository : IDisposable, IRepository<Promocode>{
    }
}
