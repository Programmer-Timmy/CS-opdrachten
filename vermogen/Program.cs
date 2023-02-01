namespace vermogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double spaning = 240;
            double stroomsterkte = 0;

            stroomsterkte = double.Parse(Console.ReadLine());
            Console.WriteLine(stroomsterkte * spaning);
        }
    }
}