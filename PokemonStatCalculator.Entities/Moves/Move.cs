using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public abstract class Move
    {
        public abstract PokemonMove MoveName { get; protected set; }

        public abstract PokemonType MoveType { get; protected set; }

        public abstract MoveCategory MoveCategory { get; protected set; }

        public abstract int MovePower { get; protected set; }

        public abstract int MovePP { get; protected set; }

        public abstract int MovePriority { get; protected set; }

        public abstract Percentage MoveAccuracy { get; protected set; }

        public abstract MoveUsageType MoveUsageType { get; protected set; }

        public abstract IEnumerable<MoveEffect> MoveEffects { get; protected set; }

        public static Move CreateFromPokemonMove(PokemonMove pokemonMove) => MoveContainer.GetMoveByPokemonMove(pokemonMove);

        public bool CheckIfHasMoveEffects() => MoveEffects.Count() > 0;

        public bool CheckIfHasPriority() => MovePriority != 0;

        public bool CheckIfDoesDamage() => MoveCategory != MoveCategory.NonDamaging;

        private static class MoveContainer
        {
            private static readonly IDictionary<PokemonMove, Move> Moves = InitializeMoveContainer();

            public static Move GetMoveByPokemonMove(PokemonMove pokemonMove) => Moves[pokemonMove];

            private static Dictionary<PokemonMove, Move> InitializeMoveContainer() => new Dictionary<PokemonMove, Move>()
            {
                { PokemonMove.Accelerock, new AccelerockMove() },
                { PokemonMove.Acrobatics, new AcrobaticsMove() },
                { PokemonMove.AerialAce, new AerialAceMove() },
                { PokemonMove.Agility, new AgilityMove() },
                { PokemonMove.AirSlash, new AirSlashMove() },
                { PokemonMove.AncientPower, new AncientPowerMove() },
                { PokemonMove.AppleAcid, new AppleAcidMove() },
                { PokemonMove.AquaRing, new AquaRingMove() },
                { PokemonMove.AttackOrder, new AttackOrderMove() },
                { PokemonMove.BabyDollEyes, new BabyDollEyesMove() },
                { PokemonMove.BehemothBlade, new BehemothBladeMove() },
                { PokemonMove.BellyDrum, new BellyDrumMove() },
                { PokemonMove.BlazeKick, new BlazeKickMove() },
                { PokemonMove.BulkUp, new BulkUpMove() },
                { PokemonMove.Charge, new ChargeMove() },
                { PokemonMove.ClangorousSoul, new ClangorousSoulMove() },
                { PokemonMove.ClearSmog, new ClearSmogMove() },
                { PokemonMove.CloseCombat, new CloseCombatMove() },
                { PokemonMove.DrainPunch, new DrainPunchMove() },
                { PokemonMove.FakeOut, new FakeOutMove() },
                { PokemonMove.FireFang, new FireFangMove() },
                { PokemonMove.FleurCannon, new FleurCannonMove() },
                { PokemonMove.FreezingGlare, new FreezingGlareMove() },
                { PokemonMove.GigaDrain, new GigaDrainMove() },
                { PokemonMove.GlacialLance, new GlacialLanceMove() },
                { PokemonMove.HammerArm, new HammerArmMove() },
                { PokemonMove.HighJumpKick, new HighJumpKickMove() },
                { PokemonMove.HornLeech, new HornLeechMove() },
                { PokemonMove.Hurricane, new HurricaneMove() },
                { PokemonMove.IceBeam, new IceBeamMove() },
                { PokemonMove.IronHead, new IronHeadMove() },
                { PokemonMove.LeafStorm, new LeafStormMove() },
                { PokemonMove.Lunge, new LungeMove() },
                { PokemonMove.MeteorMash, new MeteorMashMove() },
                { PokemonMove.MindBlown, new MindBlownMove() },
                { PokemonMove.Moonblast, new MoonblastMove() },
                { PokemonMove.NightSlash, new NightSlashMove() },
                { PokemonMove.Nuzzle, new NuzzleMove() },
                { PokemonMove.Overdrive, new OverdriveMove() },
                { PokemonMove.PlayRough, new PlayRoughMove() },
                { PokemonMove.PoisonTail, new PoisonTailMove() },
                { PokemonMove.PowerUpPunch, new PowerUpPunchMove() },
                { PokemonMove.QuiverDance, new QuiverDanceMove() },
                { PokemonMove.RisingVoltage, new RisingVoltageMove() },
                { PokemonMove.ShadowBall, new ShadowBallMove() },
                { PokemonMove.ShellSmash, new ShellSmashMove() },
            };
        }
    }
}