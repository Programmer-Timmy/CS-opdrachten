namespace verguning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("is het een constructie van enige omcang?");
            if(Console.ReadLine() == "ja")
            {
                Console.WriteLine("is het een verlichte reclame");
                if (Console.ReadLine() == "ja")
                {
                    Console.WriteLine("tevens omgevingsvergunning apv");
                }
                else
                {
                    Console.WriteLine("aleen omgevins verguning");
                }
            }
            else
            {
                Console.WriteLine("uitzonderings regels apv?");
                if (Console.ReadLine() == "ja")
                {
                    Console.WriteLine("geen omgevings verguning");
                }
                else
                {
                    Console.WriteLine("omgevings verguning");
                }
            }
            
        }
    }
}