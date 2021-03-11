using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public abstract class ContactAbilityEffect : AbilityEffect
    {
        protected ContactAbilityEffect(IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
        }

        public IEnumerable<PokemonMove> GetPokemonMovesThatInflictDamageWithContact()
        {
            return Enumerable.AsEnumerable(new List<PokemonMove>
            {
                PokemonMove.Accelerock,
                PokemonMove.Acrobatics,
                PokemonMove.AerialAce,
                PokemonMove.AttackOrder,
                PokemonMove.BehemothBlade,
                PokemonMove.BlazeKick,
                PokemonMove.CloseCombat,
                PokemonMove.DrainPunch,
                PokemonMove.FakeOut,
                PokemonMove.FireFang,
                PokemonMove.GlacialLance,
                PokemonMove.HammerArm,
                PokemonMove.HighJumpKick,
                PokemonMove.HornLeech,
                PokemonMove.IronHead,
                PokemonMove.Lunge,
                PokemonMove.MeteorMash,
                PokemonMove.NightSlash,
                PokemonMove.Nuzzle,
                PokemonMove.PlayRough,
                PokemonMove.PoisonTail,
                PokemonMove.PowerUpPunch,
            });
        }
    }
}