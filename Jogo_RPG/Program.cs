using Jogo_RPG.src.Entities;
using static System.Console;

namespace Jogo_RPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "", 749, 72);
            Ninja wedge = new Ninja("Wedge", 42, "", 574, 89);
            Wizard jenica = new Wizard("Jenica", 42, "White", 601, 482);
            Wizard topapa = new Wizard("Topapa", 42, "Black", 385, 641);

            WriteLine("===========================");
            WriteLine(arus);
            WriteLine("===========================");
            WriteLine(wedge);
            WriteLine("===========================");
            WriteLine(jenica);
            WriteLine("===========================");
            WriteLine(topapa);
        }

    }
}



