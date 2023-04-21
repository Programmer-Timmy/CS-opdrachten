namespace verbruik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double afstand = 0;
            double liter = 0;

            afstand = double.Parse(Console.ReadLine());
            liter = double.Parse(Console.ReadLine());

            double verbruik = liter * 100 / afstand;
        }
    }
}