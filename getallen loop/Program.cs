namespace getallen_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 0;
            int max = 250;

            max = int.Parse(Console.ReadLine());

            while (teller <= max)
            {
                Console.WriteLine(teller);

                teller++;
            }
        }
    }
}