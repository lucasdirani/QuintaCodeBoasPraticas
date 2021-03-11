using AutoMapper;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Mapping.Converters.PokemonTraining
{
    public class PokemonTypeConverter : ITypeConverter<PokemonViewModel, Pokemon>
    {
        public Pokemon Convert(PokemonViewModel source, Pokemon destination, ResolutionContext context)
        {
            return Pokemon.CreateFromPocketMonsterName(source.Name).Value;
        }
    }
}