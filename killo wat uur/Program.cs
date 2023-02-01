namespace vermogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vermogen = 0;
            double duur = 0;

            duur = double.Parse(Console.ReadLine());
            vermogen = double.Parse(Console.ReadLine());

            Console.WriteLine(vermogen / duur);
        }
    }
}