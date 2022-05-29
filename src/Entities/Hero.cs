namespace projeto_dio_1.src.Entities
{
    public abstract class Hero
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public abstract string Attack();



    }
}