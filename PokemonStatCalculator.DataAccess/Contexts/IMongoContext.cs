using MongoDB.Driver;
using System;

namespace PokemonStatCalculator.DataAccess.Contexts
{
    public interface IMongoContext : IDisposable
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}