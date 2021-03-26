using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;

namespace OnionApp.Infrastructure.Data.Repositories {
    class PromocodeRepository : BaseRepository<Promocode>, IPromocodeRepository {
        public PromocodeRepository(ISession session) : base(session) { }
    }
}
