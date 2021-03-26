using NHibernate;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;
using System;

namespace OnionApp.Infrastructure.Data.Repositories {
    public class UnitOfWork<TSession> : IUnitOfWork<TSession> where TSession : ISession {

        private bool disposed = false;
        
        // TODO: think about how make a dictionary of repositories
        private IEmployeeRepository employeeRepository;
        private ICustomerRepository customerRepository;
        private IPartnerRepository partnerRepository;
        private IPreferenceRepository preferenceRepository;
        private IPromocodeRepository promocodeRepository;
        private IRoleRepository roleRepository;

        public IEmployeeRepository Employees {
            get {
                if (employeeRepository == null)
                    employeeRepository = new EmployeeRepository(Session);
                return employeeRepository;
            }
        }
        public ICustomerRepository Customers {
            get {
                if (customerRepository == null)
                    customerRepository = new CustomerRepository(Session);
                return customerRepository;
            }
        }
        public IPartnerRepository Partners {
            get {
                if (partnerRepository == null)
                    partnerRepository = new PartnerRepository(Session);
                return partnerRepository;
            }
        }
        public IPreferenceRepository Preferences {
            get {
                if (preferenceRepository == null)
                    preferenceRepository = new PreferenceRepository(Session);
                return preferenceRepository;
            }
        }
        public IPromocodeRepository Promocodes {
            get {
                if (promocodeRepository == null)
                    promocodeRepository = new PromocodeRepository(Session);
                return promocodeRepository;
            }
        }
        public IRoleRepository Roles {
            get {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(Session);
                return roleRepository;
            }
        }

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
    }
}
