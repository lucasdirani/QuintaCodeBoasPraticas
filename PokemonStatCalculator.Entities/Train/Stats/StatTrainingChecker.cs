using System.Linq;
using PokemonStatCalculator.Entities.Natures;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Stats.MaxStats;
using PokemonStatCalculator.Utils.ExtensionMethods;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class StatTrainingChecker : IStatTrainingChecker
    {
        public bool CheckIfTrainingIsAcceptedFor(int valueOfTrainedStat, PokemonStat trainedStat, Training training, Pokemon pokemonInTraining)
        {
            MaxStat maxStats = GetPokemonMaxStatsBasedOnNatureEffectInStat(pokemonInTraining, training.Nature, trainedStat);

            return valueOfTrainedStat.IsBetween(maxStats.InitialStatRange.Number, maxStats.FinalStatRange.Number);
        }

        private MaxStat GetPokemonMaxStatsBasedOnNatureEffectInStat(Pokemon pokemonInTraining, Nature nature, PokemonStat trainedStat)
        {
            return nature.GetNatureEffectFor(trainedStat) switch
            {
                NatureEffect.Neutral => pokemonInTraining.MaxStatsNeutralNature.Where(m => m.MaxStatFor == trainedStat).FirstOrDefault(),
                NatureEffect.Hindering => pokemonInTraining.MaxStatsHinderingNature.Where(m => m.MaxStatFor == trainedStat).FirstOrDefault(),
                NatureEffect.Beneficial or _ => pokemonInTraining.MaxStatsBeneficialNature.Where(m => m.MaxStatFor == trainedStat).FirstOrDefault(),
            };
        }
    }
}