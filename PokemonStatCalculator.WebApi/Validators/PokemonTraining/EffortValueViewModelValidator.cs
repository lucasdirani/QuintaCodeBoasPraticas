using FluentValidation;
using PokemonStatCalculator.Entities.Stats.EffortValues;
using PokemonStatCalculator.Utils.Monads.Results;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class EffortValueViewModelValidator : AbstractValidator<EffortValueViewModel>
    {
        public EffortValueViewModelValidator()
        {
            var resultEffortValues = new Result<EffortValue>();

            var errorMessage = string.Empty;

            RuleFor(e => new { e.HP, e.Attack, e.Defense, e.SpecialAttack, e.SpecialDefense, e.Speed })
                .Must(e => {
                    resultEffortValues = EffortValueBuilder
                                           .Init()
                                           .WithEffortValueHP(e.HP)
                                           .WithEffortValueAttack(e.Attack)
                                           .WithEffortValueDefense(e.Defense)
                                           .WithEffortValueSpecialAttack(e.SpecialAttack)
                                           .WithEffortValueSpecialDefense(e.SpecialDefense)
                                           .WithEffortValueSpeed(e.Speed)
                                           .Build();

                    errorMessage = resultEffortValues.Errors.Length > 0
                                        ? resultEffortValues.Errors[0]
                                        : $"The effort values must be between 0 and 255.";

                    return resultEffortValues.IsSuccess;
                })
                .WithMessage(e => errorMessage);
        }
    }
}