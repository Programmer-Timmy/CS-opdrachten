namespace gulden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            var now = date.Year;
            now = now % 19 + 1;
            Console.WriteLine(now.ToString());


        }
    }
}