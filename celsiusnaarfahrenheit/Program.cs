namespace celsiusnaarfahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variabelen
            double celsius = 0;
            double fahrenheit = 0;

            //waarde toekenen
            celsius = double.Parse(Console.ReadLine());

            //berekening
            fahrenheit = celsius * 1.8 + 32;

            //output
            Console.WriteLine(celsius.ToString() + " " + (char)0176 + "C is gelijk aan: " + fahrenheit + " " + (char)0176 + "f");
        }
    }
}