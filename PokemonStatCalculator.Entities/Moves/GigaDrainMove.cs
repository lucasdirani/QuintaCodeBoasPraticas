﻿using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.HP;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class GigaDrainMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.GigaDrain;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Grass;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 75;

        public override int MovePP { get; protected set; } = 10;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetGigaDrainMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetGigaDrainMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RestoreHPMoveEffect(
                    restoredHP: new Percentage(value: 0.5m),
                    hpRecoveredInMoreThanOneTurn: false,
                    hpRestoredOnTheSameTurn: true,
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}