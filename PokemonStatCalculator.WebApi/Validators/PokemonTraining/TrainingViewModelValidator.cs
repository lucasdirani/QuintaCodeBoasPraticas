using FluentValidation;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Validators.PokemonTraining
{
    public class TrainingViewModelValidator : AbstractValidator<TrainingViewModel>
    {
        public TrainingViewModelValidator()
        {
            RuleFor(t => t.UserTraining).SetValidator(new UserTrainingViewModelValidator());
            RuleFor(t => t.PokemonToBeTrained).SetValidator(new PokemonViewModelValidator());
            RuleFor(t => t.Nature).SetValidator(new NatureViewModelValidator());
            RuleFor(t => t.Level).SetValidator(new LevelViewModelValidator());
            RuleFor(t => t.IndividualValues).SetValidator(new IndividualValueViewModelValidator());
            RuleFor(t => t.EffortValues).SetValidator(new EffortValueViewModelValidator());
        }
    }
}