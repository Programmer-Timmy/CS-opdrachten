namespace euro_naar_pond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euro = 0;
            double pond = 0;
            double wissle = 0.91;

            Console.WriteLine("aantal euro: ");
            euro = double.Parse(Console.ReadLine());
            pond = euro * wissle;

            Console.WriteLine((char)0163 + " "+ pond);
        }
    }
}