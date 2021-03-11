using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
using PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection;
using PokemonStatCalculator.DataAccess.Repositories;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Train;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;
using PokemonStatCalculator.WebApi.Models.PokemonTraining;
using System;
using System.Threading.Tasks;

namespace PokemonStatCalculator.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonTrainingController : ControllerBase
    {
        private readonly IMapper mapper;

        private readonly AbstractValidator<TrainingViewModel> pokemonTrainingValidator;

        private readonly ITrainingStrategy trainingStrategy;

        private readonly IUserTrainedPokemonRepository userTrainedPokemonRepository;

        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();

        public PokemonTrainingController(
            IMapper mapper,
            AbstractValidator<TrainingViewModel> pokemonTrainingValidator,
            ITrainingStrategy trainingStrategy,
            IUserTrainedPokemonRepository userTrainedPokemonRepository)
        {
            this.mapper = mapper;
            this.pokemonTrainingValidator = pokemonTrainingValidator;
            this.trainingStrategy = trainingStrategy;
            this.userTrainedPokemonRepository = userTrainedPokemonRepository;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ApplyPokemonTraining(TrainingViewModel pokemonTraining)
        {
            try
            {
                logger.Info("Requested pokemon training {0}", pokemonTraining.ToJson());

                ValidationResult validationResult = pokemonTrainingValidator.Validate(pokemonTraining);

                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult.Errors);
                }

                Pokemon pokemonToBeTrained = mapper.Map<Pokemon>(pokemonTraining.PokemonToBeTrained);

                Training trainingToBeApplied = mapper.Map<Training>(pokemonTraining);

                Result<PokemonTrained> pokemonTrainingResult = pokemonToBeTrained.ApplyTraining(trainingToBeApplied, trainingStrategy);

                if (pokemonTrainingResult.Failure)
                {
                    logger.Warn("Pokemon training failed {0}", pokemonTrainingResult.ToJson());

                    return BadRequest(pokemonTrainingResult.Errors);
                }

                UserTrainedPokemon userTrainedPokemon = mapper.Map<UserTrainedPokemon>(pokemonTrainingResult.Value);

                userTrainedPokemon.User = mapper.Map<UserTrainer>(pokemonTraining.UserTraining);

                await userTrainedPokemonRepository.Add(userTrainedPokemon);

                logger.Info("Pokemon training completed");

                return CreatedAtAction(nameof(GetPokemonTraining), new { id = userTrainedPokemon.Id }, userTrainedPokemon);
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, ex.Message);

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:Guid}")]
        [Authorize]
        [ActionName(nameof(GetPokemonTraining))]
        public async Task<IActionResult> GetPokemonTraining(Guid id)
        {
            try
            {
                logger.Info("Requested pokemon training {0}", id);

                UserTrainedPokemon userTrainedPokemon = await userTrainedPokemonRepository.GetById(id);

                if (userTrainedPokemon is null)
                {
                    logger.Info("Pokemon training not found {0}", id);

                    return NotFound();
                }

                logger.Info("Pokemon training founded {0}", id);

                return Ok(userTrainedPokemon);
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, ex.Message);

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}