namespace leeftijdcheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime geboorte = now;
            double leeftijdjaren = 0;

            geboorte = DateTime.Parse(Console.ReadLine());

            TimeSpan leeftijd = now - geboorte;
            leeftijdjaren = leeftijd.Days / 365.25;
            if(leeftijdjaren >= 18)
            {
                Console.WriteLine("drink bier in plaats van water");
            }
            else
            {
                Console.WriteLine("drink water");
                //opdracht 4
                Console.WriteLine("geslacht? ");
                string geslacht = Console.ReadLine();

                if(geslacht == "jongen") {
                    Console.WriteLine("je hebt peg je mag aleen nog water");
                    Console.WriteLine("je mag drinken vanaf " + geboorte.AddYears(18).ToShortDateString());
                }
                else
                {
                    Console.WriteLine("wat wil je wel drinken?");
                }
            }
        }
    }
}