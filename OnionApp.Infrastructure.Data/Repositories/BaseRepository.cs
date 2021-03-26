using NHibernate;
using OnionApp.Domain.Core.DbEntities;
using OnionApp.Domain.Interfaces.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Data.Repositories {
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : Entity {


        protected readonly ISession Session;

        public BaseRepository(ISession session) {
            this.Session = session;
        }

        public void Create(TEntity item) {
            Session.Save(item);
        }

        public async Task CreateAsync(TEntity item) {
            Session.SaveAsync(item);
        }

        public void Delete(int id) {
            Session.Delete(GetById(id));
        }

        public async Task DeleteAsync(int id) {
            await Session.DeleteAsync(GetByIdAsync(id));
        }
        // TODO: implement method Dispose
        public void Dispose() {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll() {
            return Session.Query<TEntity>().Where(x => !x.IsDeleted);
        }

        public Task<IEnumerable<TEntity>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAllIncludeDeleted() {
            return Session.Query<TEntity>();
        }

        public Task<IEnumerable<TEntity>> GetAllIncludeDeletedAsync() {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id) {
            return Session.Get<TEntity>(id);
        }

        public async Task<TEntity> GetByIdAsync(int id) {
            return await Session.GetAsync<TEntity>(id);
        }

        public void Save(TEntity item) {
            Session.Save(item);
        }

        public async Task SaveAsync(TEntity item) {
            await Session.SaveAsync(item);
        }

        public void Update(TEntity item) {
            Session.Update(item);
        }

        public async Task UpdateAsync(TEntity item) {
            await Session.UpdateAsync(item);
        }
    }
}
