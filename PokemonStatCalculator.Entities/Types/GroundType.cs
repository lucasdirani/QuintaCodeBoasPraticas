using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class GroundType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Ground;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Electric,
            });
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Poison,
                PokemonType.Rock,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fire,
                PokemonType.Rock,
                PokemonType.Steel,
                PokemonType.Electric,
                PokemonType.Poison,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Water,
                PokemonType.Grass,
                PokemonType.Ice,
            });
        }
    }
}