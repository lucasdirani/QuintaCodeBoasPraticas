using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class RaiseMovesOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public RaiseMovesOnWeatherConditionAbilityEffect(
            IEnumerable<PokemonType> raisedMovesFromTypes,
            IEnumerable<MoveCategory> raisedMovesFromCategory,
            Percentage raisedMovesPercentage,
            WeatherConditionType raisedMovesOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(raisedMovesOn, affectedBattleParticipants)
        {
            RaisedMovesFromTypes = raisedMovesFromTypes;
            RaisedMovesFromCategory = raisedMovesFromCategory;
            RaisedMovesPercentage = raisedMovesPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.RaiseMovesOnWeatherCondition;

        public IEnumerable<PokemonType> RaisedMovesFromTypes { get; private set; }

        public IEnumerable<MoveCategory> RaisedMovesFromCategory { get; private set; }

        public Percentage RaisedMovesPercentage { get; private set; }
    }
}