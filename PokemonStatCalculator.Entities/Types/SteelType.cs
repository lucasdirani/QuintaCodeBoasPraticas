using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class SteelType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Steel;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Poison,
            });
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Normal,
                PokemonType.Grass,
                PokemonType.Ice,
                PokemonType.Flying,
                PokemonType.Psychic,
                PokemonType.Bug,
                PokemonType.Rock,
                PokemonType.Dragon,
                PokemonType.Steel,
                PokemonType.Fairy,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Rock,
                PokemonType.Ice,
                PokemonType.Fairy,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Ground,
                PokemonType.Fighting,
                PokemonType.Fire,
            });
        }
    }
}