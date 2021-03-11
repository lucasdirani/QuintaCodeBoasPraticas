using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities
{
    public sealed class ChlorophyllAbility : Ability
    {
        public override bool CheckIfAbilityActivatesOnExitingfTheBattle()
        {
            return false;
        }

        public override bool CheckIfAbilityActivatesOnTheBeginningfTheBattle()
        {
            return false;
        }

        public override bool CheckIfAbilityActivatesOnTheEndOfTheTurn()
        {
            return false;
        }

        public override bool CheckIfAbilityCanBeCopied()
        {
            return true;
        }

        public override IEnumerable<AbilityEffect> GetAbilityEffects()
        {
            return new List<AbilityEffect>
            {
                new RaiseStatsOnWeatherConditionAbilityEffect(
                    statsRaiseStage: new Stage(2),
                    raisedStats: new List<PokemonStat> { PokemonStat.Speed, },
                    raisedOn: WeatherConditionType.Sun,
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }

        public override PokemonAbility GetPokemonAbility()
        {
            return PokemonAbility.Chlorophyll;
        }

        protected override IEnumerable<PokemonAbility> GetImmunyAbilities()
        {
            return Enumerable.Empty<PokemonAbility>();
        }
    }
}