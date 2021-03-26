using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;

namespace OnionApp.Infrastructure.Data.Repositories {
    class RoleRepository : BaseRepository<Role>, IRoleRepository {
        public RoleRepository(ISession session) : base(session) { }
    }
}
