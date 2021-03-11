using System;
using PokemonStatCalculator.Utils.ExtensionMethods;

namespace PokemonStatCalculator.Entities.Pokemons
{
    public sealed class PokemonLevel
    {
        private const int MinimumLevel = 1;

        private const int MaximumLevel = 100;

        public PokemonLevel(int currentLevel)
        {
            if (currentLevel.IsNotBetween(MinimumLevel, MaximumLevel))
            {
                throw new InvalidOperationException("The level must be between 1 and 100.");
            }

            CurrentLevel = currentLevel;
        }

        public int CurrentLevel { get; private set; }

        public int GetNextLevel()
        {
            return CurrentLevel < MaximumLevel ? CurrentLevel + 1 : CurrentLevel;
        }

        public int GetPreviousLevel()
        {
            return CurrentLevel > MinimumLevel ? CurrentLevel - 1 : CurrentLevel;
        }
    }
}