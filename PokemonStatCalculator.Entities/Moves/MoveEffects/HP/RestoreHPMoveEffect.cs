using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.HP
{
    public sealed class RestoreHPMoveEffect : MoveEffect
    {
        public RestoreHPMoveEffect(
            Percentage restoredHP,
            bool hpRestoredOnTheSameTurn,
            bool hpRecoveredInMoreThanOneTurn,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            RestoredHP = restoredHP;
            HPRestoredOnTheSameTurn = hpRestoredOnTheSameTurn;
            HPRecoveredInMoreThanOneTurn = hpRecoveredInMoreThanOneTurn;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.RestoreHP;

        public Percentage RestoredHP { get; private set; }

        public bool HPRestoredOnTheSameTurn { get; private set; }

        public bool HPRecoveredInMoreThanOneTurn { get; private set; }
    }
}