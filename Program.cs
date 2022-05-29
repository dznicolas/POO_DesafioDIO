using System;
namespace DesafioRPG.src.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, 150, "Knight");
            Ninja ninja = new Ninja("Wedge", 23, 120, "Ninja");
            WizardW wizardw = new WizardW("Jenica", 23, 95, "White Wizard");
            WizardB wizardb = new WizardB("Topapa", 23, 110, "Black Wizard");

            Console.Write(wizardw.Attack(2));
            Console.WriteLine();
            Console.Write(wizardb.Attack(7));
        }
    }
}