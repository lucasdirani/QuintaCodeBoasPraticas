using MongoDB.Bson.Serialization;
using PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection;

namespace PokemonStatCalculator.DataAccess.Mapping
{
    public class UserTrainedPokemonMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<UserTrainedPokemon>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.MapMember(x => x.Pokemon).SetIsRequired(true);
                map.MapMember(x => x.User).SetIsRequired(true);
                map.MapMember(x => x.Training).SetIsRequired(true);
            });
        }
    }
}