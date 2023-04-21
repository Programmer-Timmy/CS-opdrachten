namespace maandnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maand = "januari";
            maand = Console.ReadLine();

            if(maand == "januari")
            {
                Console.WriteLine("wintermaand");
            }
            if (maand == "februari")
            {
                Console.WriteLine("sprokkelmaand");
            }
            if (maand == "maart")
            {
                Console.WriteLine("lentemaand");
            }
            if (maand == "mei")
            {
                Console.WriteLine("bloeimaand");
            }
            if (maand == "juni")
            {
                Console.WriteLine("zommermaand");
            }
            if (maand == "juli")
            {
                Console.WriteLine("hooimaand");
            }
            if (maand == "augustus")
            {
                Console.WriteLine("oogstmaand");
            }
            if (maand == "september")
            {
                Console.WriteLine("herfstmaand");
            }
            if (maand == "oktober")
            {
                Console.WriteLine("wijnmaand");
            }
            if (maand == "november")
            {
                Console.WriteLine("slachtmaand");
            }
            if (maand == "december")
            {
                Console.WriteLine("sneeuwmaand");
            }
        }
    }
}