using FluentValidation;
using PokemonStatCalculator.Entities.Stats.IndividualValues;
using PokemonStatCalculator.Utils.Monads.Results;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class IndividualValueViewModelValidator : AbstractValidator<IndividualValueViewModel>
    {
        public IndividualValueViewModelValidator()
        {
            var resultIndividualValues = new Result<IndividualValue>();

            var errorMessage = string.Empty;

            RuleFor(i => new { i.HP, i.Attack, i.Defense, i.SpecialAttack, i.SpecialDefense, i.Speed })
                .Must(i => {
                    resultIndividualValues = IndividualValueBuilder
                                               .Init()
                                               .WithIndividualValueHP(i.HP)
                                               .WithIndividualValueAttack(i.Attack)
                                               .WithIndividualValueDefense(i.Defense)
                                               .WithIndividualValueSpecialAttack(i.SpecialAttack)
                                               .WithIndividualValueSpecialDefense(i.SpecialDefense)
                                               .WithIndividualValueSpeed(i.Speed)
                                               .Build();

                    errorMessage = resultIndividualValues.Errors.Length > 0
                                        ? resultIndividualValues.Errors[0]
                                        : $"The individual values must be between 0 and 31.";

                    return resultIndividualValues.IsSuccess;
                })
                .WithMessage(i => errorMessage);
        }
    }
}