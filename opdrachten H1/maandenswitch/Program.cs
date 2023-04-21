namespace maandenswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maand = "januari";

            maand = Console.ReadLine();

            switch (maand)
            {
                case "januari":
                    {
                        Console.WriteLine("wintermaand");
                        break;
                    }
                case "februari":
                    {
                        Console.WriteLine("sprokkelmaand");
                        break;
                    }
                case "maart":
                    {
                        Console.WriteLine("lentemaand");
                        break;
                    }
                case "april":
                    {
                        Console.WriteLine("grassmaand");
                        break;
                    }
                case "mei":
                    {
                        Console.WriteLine("bloeimaand");
                        break;
                    }
                case "juni":
                    {
                        Console.WriteLine("hooimaand");
                        break;
                    }
                case "juli":
                    {
                        Console.WriteLine("hooimaand");
                        break;
                    }
                case "augustus":
                    {
                        Console.WriteLine("oogstmaand");
                        break;
                    }
                case "september":
                    {
                        Console.WriteLine("herfstmaand");
                        break;
                    }
                case "oktober":
                    {
                        Console.WriteLine("wijnmaand");
                        break;
                    }
                case "november":
                    {
                        Console.WriteLine("slachtmaand");
                        break;
                    }
                case "december":
                    {
                        Console.WriteLine("sneeuwmaand");
                        break;
                    }
            }
        }
    }
}