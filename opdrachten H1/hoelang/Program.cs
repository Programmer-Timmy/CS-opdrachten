using Microsoft.VisualBasic;

namespace hoelang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime vandaag = DateTime.Now;
            DateTime zomervakantie = DateTime.Parse("24-07-2023");

            TimeSpan tijdtot = zomervakantie - DateTime.Now;
            double dagen = tijdtot.Days;

            Console.WriteLine("nog " + dagen + " dagen tot zomervakantie");
        }
    }
}