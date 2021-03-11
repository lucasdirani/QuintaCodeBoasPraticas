using FluentValidation;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class UserTrainingViewModelValidator : AbstractValidator<UserTrainingViewModel>
    {
        public UserTrainingViewModelValidator()
        {
            RuleFor(u => u.UserEmail)
                .EmailAddress()
                .WithMessage(u => $"Invalid e-mail address.");

            RuleFor(u => u.Username)
                .NotEmpty()
                .NotNull()
                .WithMessage(u => $"Username is required.");
        }
    }
}