namespace projeto_dio_1.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com uma espada";
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Level}, {this.HeroType}";
        }

    }
}