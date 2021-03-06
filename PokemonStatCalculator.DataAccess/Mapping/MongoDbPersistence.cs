using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;

namespace PokemonStatCalculator.DataAccess.Mapping
{
    public static class MongoDbPersistence
    {
        public static void Configure()
        {
            UserTrainedPokemonMap.Configure();

            BsonDefaults.GuidRepresentation = GuidRepresentation.CSharpLegacy;

            var pack = new ConventionPack
            {
                new IgnoreExtraElementsConvention(true),
                new IgnoreIfDefaultConvention(true)
            };

            ConventionRegistry.Register("My Solution Conventions", pack, t => true);
        }
    }
}