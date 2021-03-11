using System.Collections.Generic;
using PokemonStatCalculator.Entities.Abilities;
using PokemonStatCalculator.Entities.Moves;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Stats.BaseStats;
using PokemonStatCalculator.Entities.Stats.MaxStats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Pokemons
{
    public class GlastrierPokemon : Pokemon
    {
        public override PocketMonster Name { get; protected set; } = PocketMonster.Glastrier;

        public override Type PrimaryType { get; protected set; } = Type.CreateFromPokemonType(PokemonType.Ice).Value;

        public override Type SecondaryType { get; protected set; } = default;

        public override Ability PrimaryAbility { get; protected set; } = Ability.CreateFromPokemonAbility(PokemonAbility.ChillingNeigh);

        public override Ability SecondaryAbility { get; protected set; } = default;

        public override Ability HiddenAbility { get; protected set; } = default;

        public override IEnumerable<Move> Movepool { get; protected set; } = new List<Move>()
        {
            { Move.CreateFromPokemonMove(PokemonMove.CloseCombat) },
            { Move.CreateFromPokemonMove(PokemonMove.GlacialLance) },
            { Move.CreateFromPokemonMove(PokemonMove.IronHead) },
            { Move.CreateFromPokemonMove(PokemonMove.IceBeam) },
            { Move.CreateFromPokemonMove(PokemonMove.PlayRough) },
        };

        public override BaseStat BaseStats { get; protected set; } = BaseStatBuilder
                                                                      .Init()
                                                                      .WithBaseStatHP(100)
                                                                      .WithBaseStatAttack(145)
                                                                      .WithBaseStatDefense(130)
                                                                      .WithBaseStatSpecialAttack(65)
                                                                      .WithBaseStatSpecialDefense(110)
                                                                      .WithBaseStatSpeed(30)
                                                                      .Build()
                                                                      .Value;

        public override IEnumerable<MaxStat> MaxStatsHinderingNature { get; protected set; } = new List<MaxStat>()
        {
            { new MaxStat(maxStatFor: PokemonStat.HP, initialStatRange: new HPStat(310), finalStatRange: new HPStat(404)) },
            { new MaxStat(maxStatFor: PokemonStat.Attack, initialStatRange: new AttackStat(265), finalStatRange: new AttackStat(350)) },
            { new MaxStat(maxStatFor: PokemonStat.Defense, initialStatRange: new DefenseStat(238), finalStatRange: new DefenseStat(323)) },
            { new MaxStat(maxStatFor: PokemonStat.SpecialAttack, initialStatRange: new SpecialAttackStat(121), finalStatRange: new SpecialAttackStat(206)) },
            { new MaxStat(maxStatFor: PokemonStat.SpecialDefense, initialStatRange: new SpecialDefenseStat(202), finalStatRange: new SpecialDefenseStat(287)) },
            { new MaxStat(maxStatFor: PokemonStat.Speed, initialStatRange: new SpeedStat(58), finalStatRange: new SpeedStat(143)) },
        };

        public override IEnumerable<MaxStat> MaxStatsNeutralNature { get; protected set; } = new List<MaxStat>()
        {
            { new MaxStat(maxStatFor: PokemonStat.HP, initialStatRange: new HPStat(310), finalStatRange: new HPStat(404)) },
            { new MaxStat(maxStatFor: PokemonStat.Attack, initialStatRange: new AttackStat(295), finalStatRange: new AttackStat(389)) },
            { new MaxStat(maxStatFor: PokemonStat.Defense, initialStatRange: new DefenseStat(265), finalStatRange: new DefenseStat(359)) },
            { new MaxStat(maxStatFor: PokemonStat.SpecialAttack, initialStatRange: new SpecialAttackStat(135), finalStatRange: new SpecialAttackStat(229)) },
            { new MaxStat(maxStatFor: PokemonStat.SpecialDefense, initialStatRange: new SpecialDefenseStat(225), finalStatRange: new SpecialDefenseStat(319)) },
            { new MaxStat(maxStatFor: PokemonStat.Speed, initialStatRange: new SpeedStat(65), finalStatRange: new SpeedStat(159)) },
        };

        public override IEnumerable<MaxStat> MaxStatsBeneficialNature { get; protected set; } = new List<MaxStat>()
        {
            { new MaxStat(maxStatFor: PokemonStat.HP, initialStatRange: new HPStat(310), finalStatRange: new HPStat(404)) },
            { new MaxStat(maxStatFor: PokemonStat.Attack, initialStatRange: new AttackStat(324), finalStatRange: new AttackStat(427)) },
            { new MaxStat(maxStatFor: PokemonStat.Defense, initialStatRange: new DefenseStat(291), finalStatRange: new DefenseStat(394)) },
            { new MaxStat(maxStatFor: PokemonStat.SpecialAttack, initialStatRange: new SpecialAttackStat(148), finalStatRange: new SpecialAttackStat(251)) },
            { new MaxStat(maxStatFor: PokemonStat.SpecialDefense, initialStatRange: new SpecialDefenseStat(247), finalStatRange: new SpecialDefenseStat(350)) },
            { new MaxStat(maxStatFor: PokemonStat.Speed, initialStatRange: new SpeedStat(71), finalStatRange: new SpeedStat(174)) },
        };

        public override decimal Height { get; protected set; } = 2.2m;

        public override decimal Weight { get; protected set; } = 800.0m;
    }
}