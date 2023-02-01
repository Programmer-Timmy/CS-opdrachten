using System.Reflection.Metadata.Ecma335;

namespace moterrijbewijs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime geboorte = DateTime.Now;
            DateTime rijbewijs = DateTime.Now;
            double leeftijdjaren = 0;
            double rijbewijsjaren = 0;


            geboorte = DateTime.Parse(Console.ReadLine());
            rijbewijs = DateTime.Parse(Console.ReadLine());

            TimeSpan leeftijd = DateTime.Now - geboorte;
            leeftijdjaren = leeftijd.Days / 365.25;

            TimeSpan rijbewijs2 = DateTime.Now - rijbewijs;
            rijbewijsjaren = rijbewijs2.Days / 365.25;

            if(leeftijdjaren < 20 || leeftijdjaren >= 18) {
                Console.WriteLine("geen eisen");
                Console.WriteLine("rijgebwijs a1! 11kw");
            }
            if (leeftijdjaren < 22 || leeftijdjaren >= 20)
            {
                if(rijbewijsjaren >=2){
                    Console.WriteLine("suc6");
                    Console.WriteLine("rijgebwijs a2! 30 tot 35kw");
                }
            }
            if (leeftijdjaren >= 22)
            {
                if (rijbewijsjaren >= 2)
                {
                    Console.WriteLine("suc6");
                    Console.WriteLine("rijgebwijs a2! onbeperkt");
                }
                Console.WriteLine("nog even wachten");

            }

        }
    }
}