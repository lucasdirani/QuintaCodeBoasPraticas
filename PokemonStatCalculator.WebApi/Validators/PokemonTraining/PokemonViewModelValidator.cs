using FluentValidation;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class PokemonViewModelValidator : AbstractValidator<PokemonViewModel>
    {
        public PokemonViewModelValidator()
        {
            RuleFor(p => p.Name)
                .Must(p => Pokemon.CheckIfPokemonIsAvailable(p))
                .WithMessage(p => $"The searched pokemon {p.Name} is not available.");
        }
    }
}