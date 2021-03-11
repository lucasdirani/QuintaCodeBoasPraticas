using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Terrains;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats
{
    public sealed class TerrainStatIncreasingAbilityEffect : StatIncreasingAbilityEffect
    {
        public TerrainStatIncreasingAbilityEffect(
            TerrainType increasingBasedOnTerrain,
            IEnumerable<PokemonStat> increasingStats,
            Stage increasingStatsStage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasingStats, increasingStatsStage, affectedBattleParticipants)
        {
            IncreasingBasedOnTerrain = increasingBasedOnTerrain;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.TerrainStatIncreasing;

        public TerrainType IncreasingBasedOnTerrain { get; private set; }
    }
}