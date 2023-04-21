namespace reisbeleid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i have an onsite appointment is it necessart to travel there");
            if (Console.ReadLine() == "ja")
            {
                Console.WriteLine("i will travel there");
                Console.WriteLine("is the journey shorter than 50 km?");
                if(Console.ReadLine() == "ja")
                {
                    Console.WriteLine("il take the train");
                }
                else
                {
                    Console.WriteLine("i can take a flight there");
                }
            }
            else
            {
                Console.WriteLine("aleen omgevins verguning");
            }
        }
    }
}