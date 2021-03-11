using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Types;
using PokemonStatCalculator.Entities.WeatherConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.WeatherCondition
{
    public sealed class ChangeTypeOnWeatherConditionAbilityEffect : WeatherConditionAbilityEffect
    {
        public ChangeTypeOnWeatherConditionAbilityEffect(
            PokemonType newPokemonType,
            WeatherConditionType typeChangedOn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(typeChangedOn, affectedBattleParticipants)
        {
            NewPokemonType = newPokemonType;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.ChangeTypeOnWeatherCondition;

        public PokemonType NewPokemonType { get; private set; }
    }
}