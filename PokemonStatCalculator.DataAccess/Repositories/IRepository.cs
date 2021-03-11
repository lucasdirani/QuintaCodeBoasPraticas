using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokemonStatCalculator.DataAccess.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);

        Task<TEntity> GetById(Guid id);

        Task<IEnumerable<TEntity>> GetAll();

        Task Update(TEntity entity);

        Task Remove(Guid id);
    }
}