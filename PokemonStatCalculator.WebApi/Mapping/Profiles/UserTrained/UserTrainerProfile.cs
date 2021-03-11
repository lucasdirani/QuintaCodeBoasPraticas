using AutoMapper;
using PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Mapping.Profiles.UserTrained
{
    public class UserTrainerProfile : Profile
    {
        public UserTrainerProfile()
        {
            CreateMap<UserTrainingViewModel, UserTrainer>()
              .ForMember(dest =>
                  dest.Email,
                  opt => opt.MapFrom(src => src.UserEmail))
              .ForMember(dest =>
                  dest.Name,
                  opt => opt.MapFrom(src => src.Username));
        }
    }
}