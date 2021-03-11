using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Terrains;

namespace PokemonStatCalculator.Entities.Abilities
{
    public sealed class GrassPeltAbility : Ability
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
                new TerrainStatIncreasingAbilityEffect(
                    increasingBasedOnTerrain: TerrainType.Grassy,
                    increasingStats: new List<PokemonStat> { PokemonStat.Defense, },
                    increasingStatsStage: new Stage(1),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }

        public override PokemonAbility GetPokemonAbility()
        {
            return PokemonAbility.GrassPelt;
        }

        protected override IEnumerable<PokemonAbility> GetImmunyAbilities()
        {
            return Enumerable.Empty<PokemonAbility>();
        }
    }
}