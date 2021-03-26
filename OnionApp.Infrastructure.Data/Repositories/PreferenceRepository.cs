using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;

namespace OnionApp.Infrastructure.Data.Repositories {
    class PreferenceRepository : BaseRepository<Preference>, IPreferenceRepository {
        public PreferenceRepository(ISession session) : base(session) { }
    }
}
