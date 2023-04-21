namespace omtrek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengte = 0;
            double breete = 0;

            Console.WriteLine("lengte: ");
            lengte = double.Parse(Console.ReadLine());
            Console.WriteLine("breete: ");
            breete = double.Parse(Console.ReadLine());

            Console.WriteLine("de omtrek is " + Math.Pow(lengte, 2) + Math.Pow(breete, 2));
        }
    }
}