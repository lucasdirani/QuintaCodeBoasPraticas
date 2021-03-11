using System.Collections.Generic;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Natures
{
    public abstract class Nature
    {
        private readonly Percentage natureIncreaseStatPercentage = new Percentage(value: 0.1m);

        private readonly Percentage natureDecreaseStatPercentage = new Percentage(value: 0.1m);

        public static Result<Nature> CreateFromNatureType(string natureName)
        {
            return CreateFromNatureType(natureName.ToEnum<NatureType>(out _));
        }

        public static Result<Nature> CreateFromNatureType(NatureType natureType)
        {
            if (!CheckIfNatureIsAvailable(natureType))
            {
                return Result.Fail<Nature>($"The nature of {natureType.GetDescription()} is not available.");
            }

            return Result.Success(NatureContainer.GetNatureByNatureType(natureType));
        }

        public static bool CheckIfNatureIsAvailable(string nature)
        {
            return CheckIfNatureIsAvailable(nature.ToEnum<NatureType>(out _));
        }

        public static bool CheckIfNatureIsAvailable(NatureType nature)
        {
            return NatureContainer.CheckIfNatureIsAvailable(nature);
        }

        public abstract NatureType GetNatureType();

        public abstract PokemonStat GetIncreasedStat();

        public abstract PokemonStat GetDecreasedStat();

        public Percentage GetIncreasedStatPercentage() => natureIncreaseStatPercentage;

        public Percentage GetDecreasedStatPercentage() => natureDecreaseStatPercentage;

        public bool CheckIfNatureIncreasesStat(PokemonStat stat) => GetIncreasedStat() == stat;

        public bool CheckIfNatureDecreasesStat(PokemonStat stat) => GetDecreasedStat() == stat;

        public NatureEffect GetNatureEffectFor(PokemonStat stat)
        {
            if (GetIncreasedStat() == stat)
            {
                return NatureEffect.Beneficial;
            }

            if (GetDecreasedStat() == stat)
            {
                return NatureEffect.Hindering;
            }

            return NatureEffect.Neutral;
        }

        public decimal GetStatValueChangeTo(PokemonStat stat)
        {
            if (CheckIfNatureIncreasesStat(stat))
            {
                return 1.0m + GetIncreasedStatPercentage();
            }

            if (CheckIfNatureDecreasesStat(stat))
            {
                return 1.0m - GetDecreasedStatPercentage();
            }

            return 1;
        }

        private static class NatureContainer
        {
            private static readonly IDictionary<NatureType, Nature> Natures = InitializeNatureContainer();

            public static Nature GetNatureByNatureType(NatureType natureType) =>
                CheckIfNatureIsAvailable(natureType) ? Natures[natureType] : new NoneNature();

            public static bool CheckIfNatureIsAvailable(NatureType nature) => Natures.ContainsKey(nature);

            private static Dictionary<NatureType, Nature> InitializeNatureContainer() => new Dictionary<NatureType, Nature>()
            {
                { NatureType.Adamant, new AdamantNature() },
                { NatureType.Bashful, new BashfulNature() },
                { NatureType.Bold, new BoldNature() },
                { NatureType.Brave, new BraveNature() },
                { NatureType.Calm, new CalmNature() },
                { NatureType.Careful, new CarefulNature() },
                { NatureType.Docile, new DocileNature() },
                { NatureType.Gentle, new GentleNature() },
                { NatureType.Hardy, new HardyNature() },
                { NatureType.Hasty, new HastyNature() },
                { NatureType.Impish, new ImpishNature() },
                { NatureType.Jolly, new JollyNature() },
                { NatureType.Lax, new LaxNature() },
                { NatureType.Lonely, new LonelyNature() },
                { NatureType.Mild, new MildNature() },
                { NatureType.Modest, new ModestNature() },
                { NatureType.Naive, new NaiveNature() },
                { NatureType.Naughty, new NaughtyNature() },
                { NatureType.Quiet, new QuietNature() },
                { NatureType.Quirky, new QuirkyNature() },
                { NatureType.Rash, new RashNature() },
                { NatureType.Relaxed, new RelaxedNature() },
                { NatureType.Sassy, new SassyNature() },
                { NatureType.Serious, new SeriousNature() },
                { NatureType.Timid, new TimidNature() },
            };
        }
    }
}