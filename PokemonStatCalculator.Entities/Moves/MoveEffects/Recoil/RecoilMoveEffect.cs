using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Recoil
{
    public sealed class RecoilMoveEffect : MoveEffect
    {
        public RecoilMoveEffect(Percentage recoilDamage, IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            RecoilDamage = recoilDamage;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.Recoil;

        public Percentage RecoilDamage { get; private set; }
    }
}