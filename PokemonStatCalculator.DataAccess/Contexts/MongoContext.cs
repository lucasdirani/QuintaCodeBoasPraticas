using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace PokemonStatCalculator.DataAccess.Contexts
{
    public class MongoContext : IMongoContext
    {
        private readonly IConfiguration configuration;

        public MongoContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private IMongoDatabase Database { get; set; }

        public IClientSessionHandle Session { get; set; }

        public MongoClient MongoClient { get; set; }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            ConfigureMongo();

            return Database.GetCollection<T>(name);
        }

        public void Dispose()
        {
            Session?.Dispose();

            GC.SuppressFinalize(this);
        }

        private void ConfigureMongo()
        {
            if (MongoClient is not null)
            {
                return;
            }

            MongoClient = new MongoClient(configuration["MongoSettings:Connection"]);

            Database = MongoClient.GetDatabase(configuration["MongoSettings:DatabaseName"]);
        }
    }
}