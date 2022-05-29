namespace projeto_dio_1.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com uma espada";
        }
        public string Attack(int damage)
        {
            if (damage < 5)
            {
                return this.Name + " Atacou com uma espada "
                                 + "com Danos Fraco de valor " + damage;
            }
            else
            {
                return this.Name + " Atacou com uma espada "
                                 + "com Danos Extremamente Forte de valor " + damage;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Level}, {this.HeroType}, {this.Hp}, {this.Mp}";
        }

    }
}