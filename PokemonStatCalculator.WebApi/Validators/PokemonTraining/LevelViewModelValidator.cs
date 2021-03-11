using FluentValidation;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class LevelViewModelValidator : AbstractValidator<LevelViewModel>
    {
        public LevelViewModelValidator()
        {
            RuleFor(l => l.Value)
                .Must(l => l.IsBetween(0, 100))
                .WithMessage(l => $"The level must be between 0 and 100.");
        }
    }
}