using MongoDB.Driver;
using PokemonStatCalculator.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using ServiceStack;

namespace PokemonStatCalculator.DataAccess.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly IMongoContext context;

        protected readonly IMongoCollection<TEntity> dbSet;

        protected BaseRepository(IMongoContext context)
        {
            this.context = context;

            dbSet = context.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public async Task Add(TEntity entity)
        {
            await dbSet.InsertOneAsync(entity);
        }

        public void Dispose()
        {
            context?.Dispose();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var all = await dbSet.FindAsync(Builders<TEntity>.Filter.Empty);

            return all.ToList();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            var data = await dbSet.FindAsync(Builders<TEntity>.Filter.Eq("_id", id));

            return data.SingleOrDefault();
        }

        public async Task Remove(Guid id)
        {
            await dbSet.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id));
        }

        public async Task Update(TEntity entity)
        {
            await dbSet.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", entity.GetId()), entity);
        }
    }
}