using System.Collections.Generic;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.BaseStats
{
    public sealed class BaseStatBuilder : IBaseStatHP, IBaseStatAttack, IBaseStatDefense, IBaseStatSpecialAttack, IBaseStatSpecialDefense, IBaseStatSpeed, IBaseStatBuilder
    {
        private readonly BaseStat baseStat = new BaseStat();

        private readonly IList<Result> resultOfAppliedStats = new List<Result>();

        public static IBaseStatHP Init()
        {
            return new BaseStatBuilder();
        }

        public Result<BaseStat> Build()
        {
            if (resultOfAppliedStats.ContainsAnyFailure())
            {
                return Result.Fail<BaseStat>(resultOfAppliedStats.ExtractAllErrors());
            }

            return Result.Success(baseStat);
        }

        public IBaseStatDefense WithBaseStatAttack(int baseStatAttack)
        {
            Result baseStatAttackApplied = baseStat.ApplyBaseStat(new AttackStat(baseStatAttack));

            resultOfAppliedStats.Add(baseStatAttackApplied);

            return this;
        }

        public IBaseStatSpecialAttack WithBaseStatDefense(int baseStatDefense)
        {
            Result baseStatDefenseApplied = baseStat.ApplyBaseStat(new DefenseStat(baseStatDefense));

            resultOfAppliedStats.Add(baseStatDefenseApplied);

            return this;
        }

        public IBaseStatAttack WithBaseStatHP(int baseStatHP)
        {
            Result baseStatHPApplied = baseStat.ApplyBaseStat(new HPStat(baseStatHP));

            resultOfAppliedStats.Add(baseStatHPApplied);

            return this;
        }

        public IBaseStatSpecialDefense WithBaseStatSpecialAttack(int baseStatSpecialAttack)
        {
            Result baseStatSpecialAttackApplied = baseStat.ApplyBaseStat(new SpecialAttackStat(baseStatSpecialAttack));

            resultOfAppliedStats.Add(baseStatSpecialAttackApplied);

            return this;
        }

        public IBaseStatSpeed WithBaseStatSpecialDefense(int baseStatSpecialDefense)
        {
            Result baseStatSpecialDefenseApplied = baseStat.ApplyBaseStat(new SpecialDefenseStat(baseStatSpecialDefense));

            resultOfAppliedStats.Add(baseStatSpecialDefenseApplied);

            return this;
        }

        public IBaseStatBuilder WithBaseStatSpeed(int baseStatSpeed)
        {
            Result baseStatSpeedApplied = baseStat.ApplyBaseStat(new SpeedStat(baseStatSpeed));

            resultOfAppliedStats.Add(baseStatSpeedApplied);

            return this;
        }
    }
}