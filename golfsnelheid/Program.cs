namespace golfsnelheid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double golfsnelheid = 0;
            double frequintsy = 0;

            golfsnelheid = double.Parse(Console.ReadLine());
            frequintsy= double.Parse(Console.ReadLine());

            Console.WriteLine(golfsnelheid / frequintsy);
        }
    }
}