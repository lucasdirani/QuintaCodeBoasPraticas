using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    internal sealed class BehemothBladeMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.BehemothBlade;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Steel;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 100;

        public override int MovePP { get; protected set; } = 5;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetBehemothBladeMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetBehemothBladeMoveEffects()
        {
            return new List<MoveEffect>
            {
                new TargetPokemonFormPowerUpMoveEffect(
                    targetedPokemonFormsThatPowerUpMove: new List<PokemonForm>
                    {
                        PokemonForm.Dynamax,
                        PokemonForm.Gigantamax,
                    },
                    increasedBasePower: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}