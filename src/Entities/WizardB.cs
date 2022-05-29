namespace DesafioRPG.src.Entities
{
    public class WizardB : Hero
    {
        public WizardB(string Name, int Level, int Hp, string HeroType) : base(Name, Level, Hp, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Launched magic! ";
        }

        public string Attack(int Bonus)
        {

            if (Bonus > 6)
            {
                return this.Name + " Launched strong magic with bonus of: " + Bonus ;
            }
            else
            {
                return this.Name + " Launched weak magic with bonus of:  " + Bonus;

            }
        }
    }
}