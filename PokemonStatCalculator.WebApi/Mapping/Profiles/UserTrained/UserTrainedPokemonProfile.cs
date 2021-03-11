using AutoMapper;
using PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.WebApi.Mapping.Converters.UserTrained;

namespace PokemonStatCalculator.WebApi.Mapping.Profiles.UserTrained
{
    public class UserTrainedPokemonProfile : Profile
    {
        public UserTrainedPokemonProfile()
        {
            CreateMap<PokemonTrained, UserTrainedPokemon>().ConvertUsing<UserTrainedTypeConverter>();
        }
    }
}