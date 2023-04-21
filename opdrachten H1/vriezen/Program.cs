using System.ComponentModel.Design;

namespace vriezen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = 0;

            temp = double.Parse(Console.ReadLine());

            if(temp > 0)
            {
                Console.WriteLine("het is aan het dooien");
            }
            else
            {
                Console.WriteLine("het is aan het vriezen");
            }
        }
    }
}