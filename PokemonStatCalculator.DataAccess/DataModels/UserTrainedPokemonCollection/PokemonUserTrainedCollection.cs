namespace PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection
{
    public class PokemonUserTrainedCollection
    {
        public PokemonUserTrainedCollection()
        {
        }

        public PokemonUserTrainedCollection(string name, StatUserTrainedCollection baseStats)
        {
            Name = name;
            BaseStats = baseStats;
        }

        public string Name { get; set; }

        public StatUserTrainedCollection BaseStats { get; set; }
    }
}