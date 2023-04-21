namespace ibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantal = 0,
                count = 1,
                getal1 = 0,
                getal2 = 1,
                getal3 = 0;

            aantal = int.Parse(Console.ReadLine());

            while (count <= aantal) {
                getal3 = getal1 + getal2;
                Console.WriteLine(getal3);
                count++;
                getal1 = getal2;
                getal2 = getal3;
            }
        }
    }
}