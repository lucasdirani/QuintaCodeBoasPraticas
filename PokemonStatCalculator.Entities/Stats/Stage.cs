using System.Collections.Generic;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Stats
{
    public sealed class Stage
    {
        private const decimal OneStageInPercentage = 0.5m;

        public Stage(int numberOfStages)
        {
            NumberOfStages = numberOfStages;
        }

        public int NumberOfStages { get; private set; }

        public IEnumerable<Percentage> GetCorrespondingPercentageOfTheNumberOfStages()
        {
            IList<Percentage> numberOfStagesInPercentages = new List<Percentage>();

            int countNumberOfStages = NumberOfStages;

            while (countNumberOfStages > 0)
            {
                decimal percentageValue = countNumberOfStages % 2 == 0 ? OneStageInPercentage * 2 : OneStageInPercentage;

                Percentage percentage = new Percentage(percentageValue);

                numberOfStagesInPercentages.Add(percentage);

                countNumberOfStages -= countNumberOfStages % 2 == 0 ? 2 : 1;
            }

            return numberOfStagesInPercentages;
        }
    }
}