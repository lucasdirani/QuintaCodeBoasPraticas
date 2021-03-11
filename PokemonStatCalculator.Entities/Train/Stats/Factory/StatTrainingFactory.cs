using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats.Factory
{
    public class StatTrainingFactory : IStatTrainingFactory
    {
        private readonly IStatTrainingChecker statTrainingChecker;

        private IStatTrainingStrategy statTrainingStrategy;

        public StatTrainingFactory(IStatTrainingChecker statTrainingChecker)
        {
            this.statTrainingChecker = statTrainingChecker;
        }

        public Result<Stat> BuildStatWith(PokemonStat pokemonStat, Pokemon pokemon, Training training)
        {
            switch (pokemonStat)
            {
                case PokemonStat.HP:
                    statTrainingStrategy = new HPStatTrainingStrategy();
                    break;
                case PokemonStat.Attack:
                    statTrainingStrategy = new AttackStatTrainingStrategy();
                    break;
                case PokemonStat.Defense:
                    statTrainingStrategy = new DefenseStatTrainingStrategy();
                    break;
                case PokemonStat.SpecialAttack:
                    statTrainingStrategy = new SpecialAttackStatTrainingStrategy();
                    break;
                case PokemonStat.SpecialDefense:
                    statTrainingStrategy = new SpecialDefenseStatTrainingStrategy();
                    break;
                case PokemonStat.Speed:
                    statTrainingStrategy = new SpeedStatTrainingStrategy();
                    break;
            }

            return statTrainingStrategy?.ApplyStatTrainingTo(pokemon, training, statTrainingChecker);
        }
    }
}