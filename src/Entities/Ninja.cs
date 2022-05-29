namespace DesafioRPG.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, int Hp, string HeroType) : base(Name, Level, Hp, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Realized an attack with his Shuriken! ";
        }
    }
}