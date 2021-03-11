using AutoMapper;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.WebApi.Mapping.Converters.PokemonTraining;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Mapping.Profiles.PokemonTraining
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile()
        {
            CreateMap<PokemonViewModel, Pokemon>().ConvertUsing<PokemonTypeConverter>();
        }
    }
}