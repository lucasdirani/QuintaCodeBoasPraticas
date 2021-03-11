using FluentValidation;
using PokemonStatCalculator.Entities.Natures;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class NatureViewModelValidator : AbstractValidator<NatureViewModel>
    {
        public NatureViewModelValidator()
        {
            RuleFor(n => n.Name)
                .Must(n => Nature.CheckIfNatureIsAvailable(n))
                .WithMessage(n => $"The searched nature {n.Name} is not available.");
        }
    }
}