namespace tafel_van
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tafel1 = 0;
            int tafel2 = 0;

            tafel1 = int.Parse(Console.ReadLine());
            tafel2 = int.Parse(Console.ReadLine());

            int repeat1 = 1;

            while (tafel1 <= tafel2)
            {
                repeat1 = 0;
                while (repeat1 <= 10)
                {
                    Console.WriteLine(repeat1 + " x " + tafel1 + "= " + repeat1 * tafel1);
                    repeat1++;
                }

                tafel1++;
            }
        }
    }
}