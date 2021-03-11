using AutoMapper;
using PokemonStatCalculator.Entities.Natures;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats.EffortValues;
using PokemonStatCalculator.Entities.Stats.IndividualValues;
using PokemonStatCalculator.Entities.Train;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Mapping.Converters.PokemonTraining
{
    public class TrainingTypeConverter : ITypeConverter<TrainingViewModel, Training>
    {
        public Training Convert(TrainingViewModel source, Training destination, ResolutionContext context)
        {
            Nature nature = Nature.CreateFromNatureType(source.Nature.Name).Value;

            PokemonLevel pokemonLevel = new PokemonLevel(source.Level.Value);

            EffortValue effortValues = EffortValueBuilder
                                        .Init()
                                        .WithEffortValueHP(source.EffortValues.HP)
                                        .WithEffortValueAttack(source.EffortValues.Attack)
                                        .WithEffortValueDefense(source.EffortValues.Defense)
                                        .WithEffortValueSpecialAttack(source.EffortValues.SpecialAttack)
                                        .WithEffortValueSpecialDefense(source.EffortValues.SpecialDefense)
                                        .WithEffortValueSpeed(source.EffortValues.Speed)
                                        .Build()
                                        .Value;

            IndividualValue individualValues = IndividualValueBuilder
                                                .Init()
                                                .WithIndividualValueHP(source.IndividualValues.HP)
                                                .WithIndividualValueAttack(source.IndividualValues.Attack)
                                                .WithIndividualValueDefense(source.IndividualValues.Defense)
                                                .WithIndividualValueSpecialAttack(source.IndividualValues.SpecialAttack)
                                                .WithIndividualValueSpecialDefense(source.IndividualValues.SpecialDefense)
                                                .WithIndividualValueSpeed(source.IndividualValues.Speed)
                                                .Build()
                                                .Value;

            return new Training(effortValues, individualValues, nature, pokemonLevel);
        }
    }
}