namespace DesafioRPG.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, int Hp, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.HeroType = HeroType;
        }
        public string Name;

        public int Level;
        public int Hp;
        public string HeroType;

        public override string ToString()
        { // Override sobrescrita de método
            return this.Name + " " + this.Level + " " + this.Hp + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Realized an attack with his sword!  ";
        }
    }
}