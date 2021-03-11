namespace PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection
{
    public class TrainingUserTrainedCollection
    {
        public TrainingUserTrainedCollection()
        {
        }

        public TrainingUserTrainedCollection(
            int level,
            string nature,
            StatUserTrainedCollection effortValues,
            StatUserTrainedCollection individualValues,
            StatUserTrainedCollection resultedStats)
        {
            Level = level;
            Nature = nature;
            EffortValues = effortValues;
            IndividualValues = individualValues;
            ResultedStats = resultedStats;
        }

        public int Level { get; set; }

        public string Nature { get; set; }

        public StatUserTrainedCollection EffortValues { get; set; }

        public StatUserTrainedCollection IndividualValues { get; set; }

        public StatUserTrainedCollection ResultedStats { get; set; }
    }
}