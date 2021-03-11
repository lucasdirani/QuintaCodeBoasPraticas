using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Stats
{
    public abstract class StatModificationMoveEffect : MoveEffect
    {
        protected StatModificationMoveEffect(
            PokemonStat affectedStat,
            Stage affectedStatStages,
            Percentage chanceToAffectStat,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            AffectedStat = affectedStat;
            AffectedStatStages = affectedStatStages;
            ChanceToAffectStat = chanceToAffectStat;
        }

        public PokemonStat AffectedStat { get; protected set; }

        public Stage AffectedStatStages { get; protected set; }

        public Percentage ChanceToAffectStat { get; protected set; }
    }
}