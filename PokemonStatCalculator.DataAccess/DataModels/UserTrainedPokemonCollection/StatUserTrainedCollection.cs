namespace PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection
{
    public class StatUserTrainedCollection
    {
        public StatUserTrainedCollection()
        {
        }

        public StatUserTrainedCollection(int hp, int attack, int defense, int specialAttack, int specialDefense, int speed)
        {
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
        }

        public int HP { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int SpecialAttack { get; set; }

        public int SpecialDefense { get; set; }

        public int Speed { get; set; }
    }
}