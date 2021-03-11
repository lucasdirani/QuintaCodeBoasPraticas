using AutoMapper;
using PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;

namespace PokemonStatCalculator.WebApi.Mapping.Converters.UserTrained
{
    public class UserTrainedTypeConverter : ITypeConverter<PokemonTrained, UserTrainedPokemon>
    {
        public UserTrainedPokemon Convert(PokemonTrained source, UserTrainedPokemon destination, ResolutionContext context)
        {
            PokemonUserTrainedCollection pokemon = new PokemonUserTrainedCollection(
                name: source.Pokemon.Name.GetDescription(),
                baseStats: new StatUserTrainedCollection(
                    hp: source.Pokemon.BaseStats.GetBaseStatValue(PokemonStat.HP),
                    attack: source.Pokemon.BaseStats.GetBaseStatValue(PokemonStat.Attack),
                    defense: source.Pokemon.BaseStats.GetBaseStatValue(PokemonStat.Defense),
                    specialAttack: source.Pokemon.BaseStats.GetBaseStatValue(PokemonStat.SpecialAttack),
                    specialDefense: source.Pokemon.BaseStats.GetBaseStatValue(PokemonStat.SpecialDefense),
                    speed: source.Pokemon.BaseStats.GetBaseStatValue(PokemonStat.Speed)
               )
            );

            TrainingUserTrainedCollection training = new TrainingUserTrainedCollection(
                level: source.AppliedTraining.Level.CurrentLevel,
                nature: source.AppliedTraining.Nature.GetNatureType().GetDescription(),
                effortValues: new StatUserTrainedCollection(
                    hp: source.AppliedTraining.EffortValues.GetEffortValue(PokemonStat.HP),
                    attack: source.AppliedTraining.EffortValues.GetEffortValue(PokemonStat.Attack),
                    defense: source.AppliedTraining.EffortValues.GetEffortValue(PokemonStat.Defense),
                    specialAttack: source.AppliedTraining.EffortValues.GetEffortValue(PokemonStat.SpecialAttack),
                    specialDefense: source.AppliedTraining.EffortValues.GetEffortValue(PokemonStat.SpecialDefense),
                    speed: source.AppliedTraining.EffortValues.GetEffortValue(PokemonStat.Speed)
                ),
                individualValues: new StatUserTrainedCollection(
                    hp: source.AppliedTraining.IndividualValues.GetIndividualValue(PokemonStat.HP),
                    attack: source.AppliedTraining.IndividualValues.GetIndividualValue(PokemonStat.Attack),
                    defense: source.AppliedTraining.IndividualValues.GetIndividualValue(PokemonStat.Defense),
                    specialAttack: source.AppliedTraining.IndividualValues.GetIndividualValue(PokemonStat.SpecialAttack),
                    specialDefense: source.AppliedTraining.IndividualValues.GetIndividualValue(PokemonStat.SpecialDefense),
                    speed: source.AppliedTraining.IndividualValues.GetIndividualValue(PokemonStat.Speed)
                ),
                resultedStats: new StatUserTrainedCollection(
                    hp: source.TrainedStats.GetBaseStatValue(PokemonStat.HP),
                    attack: source.TrainedStats.GetBaseStatValue(PokemonStat.Attack),
                    defense: source.TrainedStats.GetBaseStatValue(PokemonStat.Defense),
                    specialAttack: source.TrainedStats.GetBaseStatValue(PokemonStat.SpecialAttack),
                    specialDefense: source.TrainedStats.GetBaseStatValue(PokemonStat.SpecialDefense),
                    speed: source.TrainedStats.GetBaseStatValue(PokemonStat.Speed)
                )
            );

            return new UserTrainedPokemon() { Pokemon = pokemon, Training = training };
        }
    }
}