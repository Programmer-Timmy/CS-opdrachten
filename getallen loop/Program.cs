namespace getallen_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teller = 1;
            int max = 250;

            max = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(teller);

                teller++;
            } while (teller <= max);
        }
    }
}