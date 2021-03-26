using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;

namespace OnionApp.Infrastructure.Data.Repositories {
    class PartnerRepository : BaseRepository<Partner>, IPartnerRepository {
        public PartnerRepository(ISession session) : base (session) { }
    }
}
