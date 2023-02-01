namespace oppervalk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengte = 0;
            double breete = 0;

            lengte = double.Parse(Console.ReadLine());
            breete = double.Parse(Console.ReadLine());

            Console.WriteLine(lengte * breete);
        }
    }
}