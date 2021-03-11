using System.Collections.Generic;
using PokemonStatCalculator.Entities.Abilities;
using PokemonStatCalculator.Entities.Moves;
using PokemonStatCalculator.Entities.Stats.BaseStats;
using PokemonStatCalculator.Entities.Stats.MaxStats;
using PokemonStatCalculator.Entities.Train;
using PokemonStatCalculator.Entities.Types;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Pokemons
{
    public abstract class Pokemon
    {
        public abstract PocketMonster Name { get; protected set; }

        public abstract Type PrimaryType { get; protected set; }

        public abstract Type SecondaryType { get; protected set; }

        public abstract Ability PrimaryAbility { get; protected set; }

        public abstract Ability SecondaryAbility { get; protected set; }

        public abstract Ability HiddenAbility { get; protected set; }

        public abstract IEnumerable<Move> Movepool { get; protected set; }

        public abstract BaseStat BaseStats { get; protected set; }

        public abstract IEnumerable<MaxStat> MaxStatsHinderingNature { get; protected set; }

        public abstract IEnumerable<MaxStat> MaxStatsNeutralNature { get; protected set; }

        public abstract IEnumerable<MaxStat> MaxStatsBeneficialNature { get; protected set; }

        public abstract decimal Height { get; protected set; }

        public abstract decimal Weight { get; protected set; }

        public static Result<Pokemon> CreateFromPocketMonsterName(string pocketMonsterName)
        {
            return CreateFromPocketMonsterName(pocketMonsterName.ToEnum<PocketMonster>(out _));
        }

        public static Result<Pokemon> CreateFromPocketMonsterName(PocketMonster pocketMonsterName)
        {
            if (!CheckIfPokemonIsAvailable(pocketMonsterName))
            {
                return Result.Fail<Pokemon>($"The pokemon {pocketMonsterName.GetDescription()} is not available.");
            }

            return Result.Success(PokemonContainer.GetPokemonByName(pocketMonsterName));
        }

        public static bool CheckIfPokemonIsAvailable(string pokemon)
        {
            PocketMonster pocketMonster = pokemon.ToEnum<PocketMonster>(out bool pokemonExists);

            if (!pokemonExists)
            {
                return false;
            }

            return CheckIfPokemonIsAvailable(pocketMonster);
        }

        public static bool CheckIfPokemonIsAvailable(PocketMonster pokemon)
        {
            return PokemonContainer.CheckIfPokemonIsAvailable(pokemon);
        }

        public Result<PokemonTrained> ApplyTraining(Training training, ITrainingStrategy trainingStrategy)
        {
            return trainingStrategy.StartTrainingTo(this, training);
        }

        private static class PokemonContainer
        {
            private static readonly IDictionary<PocketMonster, Pokemon> Pokemons = InitializePokemonContainer();

            public static Pokemon GetPokemonByName(PocketMonster pocketMonsterName)
                => CheckIfPokemonIsAvailable(pocketMonsterName) ? Pokemons[pocketMonsterName] : null;

            public static bool CheckIfPokemonIsAvailable(PocketMonster pocketMonster) => Pokemons.ContainsKey(pocketMonster);

            private static Dictionary<PocketMonster, Pokemon> InitializePokemonContainer() => new Dictionary<PocketMonster, Pokemon>()
            {
                { PocketMonster.Glastrier, new GlastrierPokemon() },
            };
        }
    }
}