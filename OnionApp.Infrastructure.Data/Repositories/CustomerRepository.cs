using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;

namespace OnionApp.Infrastructure.Data.Repositories {
    class CustomerRepository : BaseRepository<Customer>, ICustomerRepository {
        public CustomerRepository(ISession session) : base(session) { }
    }
}
