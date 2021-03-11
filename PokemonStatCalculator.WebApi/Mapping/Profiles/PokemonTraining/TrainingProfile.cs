using AutoMapper;
using PokemonStatCalculator.Entities.Train;
using PokemonStatCalculator.WebApi.Mapping.Converters.PokemonTraining;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;

namespace PokemonStatCalculator.WebApi.Mapping.Profiles.PokemonTraining
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<TrainingViewModel, Training>().ConvertUsing<TrainingTypeConverter>();
        }
    }
}