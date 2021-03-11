using System.Collections.Generic;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.IndividualValues
{
    public sealed class IndividualValueBuilder : IIndividualValueHP, IIndividualValueAttack, IIndividualValueDefense, IIndividualValueSpecialAttack, IIndividualValueSpecialDefense, IIndividualValueSpeed, IIndividualValueBuilder
    {
        private readonly IndividualValue individualValues = new IndividualValue();

        private readonly IList<Result> resultOfAppliedIndividualValues = new List<Result>();

        public static IIndividualValueHP Init()
        {
            return new IndividualValueBuilder();
        }

        public Result<IndividualValue> Build()
        {
            if (resultOfAppliedIndividualValues.ContainsAnyFailure())
            {
                return Result.Fail<IndividualValue>(resultOfAppliedIndividualValues.ExtractAllErrors());
            }

            return Result.Success(individualValues);
        }

        public IIndividualValueDefense WithIndividualValueAttack(int individualValueAttack)
        {
            Result individualValueAttackApplied = individualValues.ApplyIndividualValue(new AttackStat(individualValueAttack));

            resultOfAppliedIndividualValues.Add(individualValueAttackApplied);

            return this;
        }

        public IIndividualValueSpecialAttack WithIndividualValueDefense(int individualValueDefense)
        {
            Result individualValueDefenseApplied = individualValues.ApplyIndividualValue(new DefenseStat(individualValueDefense));

            resultOfAppliedIndividualValues.Add(individualValueDefenseApplied);

            return this;
        }

        public IIndividualValueAttack WithIndividualValueHP(int individualValueHP)
        {
            Result individualValueHPApplied = individualValues.ApplyIndividualValue(new HPStat(individualValueHP));

            resultOfAppliedIndividualValues.Add(individualValueHPApplied);

            return this;
        }

        public IIndividualValueSpecialDefense WithIndividualValueSpecialAttack(int individualValueSpecialAttack)
        {
            Result individualValueSpecialAttackApplied = individualValues.ApplyIndividualValue(new SpecialAttackStat(individualValueSpecialAttack));

            resultOfAppliedIndividualValues.Add(individualValueSpecialAttackApplied);

            return this;
        }

        public IIndividualValueSpeed WithIndividualValueSpecialDefense(int individualValueSpecialDefense)
        {
            Result individualValueSpecialDefenseApplied = individualValues.ApplyIndividualValue(new SpecialDefenseStat(individualValueSpecialDefense));

            resultOfAppliedIndividualValues.Add(individualValueSpecialDefenseApplied);

            return this;
        }

        public IIndividualValueBuilder WithIndividualValueSpeed(int individualValueSpeed)
        {
            Result individualValueSpeedApplied = individualValues.ApplyIndividualValue(new SpeedStat(individualValueSpeed));

            resultOfAppliedIndividualValues.Add(individualValueSpeedApplied);

            return this;
        }
    }
}