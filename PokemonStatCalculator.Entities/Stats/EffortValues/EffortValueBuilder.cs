using System.Collections.Generic;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.EffortValues
{
    public sealed class EffortValueBuilder : IEffortValueHP, IEffortValueAttack, IEffortValueDefense, IEffortValueSpecialAttack, IEffortValueSpecialDefense, IEffortValueSpeed, IEffortValueBuilder
    {
        private readonly EffortValue effortValues = new EffortValue();

        private readonly IList<Result> resultOfAppliedEffortValues = new List<Result>();

        public static IEffortValueHP Init()
        {
            return new EffortValueBuilder();
        }

        public Result<EffortValue> Build()
        {
            if (resultOfAppliedEffortValues.ContainsAnyFailure())
            {
                return Result.Fail<EffortValue>(resultOfAppliedEffortValues.ExtractAllErrors());
            }

            return Result.Success(effortValues);
        }

        public IEffortValueDefense WithEffortValueAttack(int effortValueAttack)
        {
            Result effortValueAttackApplied = effortValues.ApplyEffortValue(new AttackStat(effortValueAttack));

            resultOfAppliedEffortValues.Add(effortValueAttackApplied);

            return this;
        }

        public IEffortValueSpecialAttack WithEffortValueDefense(int effortValueDefense)
        {
            Result effortValueDefenseApplied = effortValues.ApplyEffortValue(new DefenseStat(effortValueDefense));

            resultOfAppliedEffortValues.Add(effortValueDefenseApplied);

            return this;
        }

        public IEffortValueAttack WithEffortValueHP(int effortValueHP)
        {
            Result effortValueHPApplied = effortValues.ApplyEffortValue(new HPStat(effortValueHP));

            resultOfAppliedEffortValues.Add(effortValueHPApplied);

            return this;
        }

        public IEffortValueSpecialDefense WithEffortValueSpecialAttack(int effortValueSpecialAttack)
        {
            Result effortValueSpecialAttackApplied = effortValues.ApplyEffortValue(new SpecialAttackStat(effortValueSpecialAttack));

            resultOfAppliedEffortValues.Add(effortValueSpecialAttackApplied);

            return this;
        }

        public IEffortValueSpeed WithEffortValueSpecialDefense(int effortValueSpecialDefense)
        {
            Result effortValueSpecialDefenseApplied = effortValues.ApplyEffortValue(new SpecialDefenseStat(effortValueSpecialDefense));

            resultOfAppliedEffortValues.Add(effortValueSpecialDefenseApplied);

            return this;
        }

        public IEffortValueBuilder WithEffortValueSpeed(int effortValueSpeed)
        {
            Result effortValueSpeedApplied = effortValues.ApplyEffortValue(new SpeedStat(effortValueSpeed));

            resultOfAppliedEffortValues.Add(effortValueSpeedApplied);

            return this;
        }
    }
}