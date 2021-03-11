namespace PokemonStatCalculator.Entities.Stats
{
    public abstract class Stat
    {
        protected Stat(int number)
        {
            Number = number;
        }

        public abstract PokemonStat Classification { get; protected set; }

        public int Number { get; protected set; }
    }
}