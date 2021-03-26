using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnionApp.Domain.Core.DbEntities;

namespace OnionApp.Domain.Interfaces.Abstractions.Repositories {
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity {


        // TODO: delete some methods in IRepository
        Task<IEnumerable<TEntity>> GetAllIncludeDeletedAsync();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task CreateAsync(TEntity item);
        Task UpdateAsync(TEntity item);
        Task DeleteAsync(int id);
        Task SaveAsync(TEntity item);
        IEnumerable<TEntity> GetAllIncludeDeleted();
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
        void Save(TEntity item);
    }
}
