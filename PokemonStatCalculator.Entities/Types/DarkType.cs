using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class DarkType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Dark;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Psychic,
            });
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Dark,
                PokemonType.Ghost,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Ghost,
                PokemonType.Psychic,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fighting,
                PokemonType.Fairy,
                PokemonType.Bug,
            });
        }
    }
}