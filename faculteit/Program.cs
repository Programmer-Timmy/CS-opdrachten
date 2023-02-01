using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace faculteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ;

            int startnumber = 1;
            int endnumber = 0;
            int result = 1;
            string output = "";
            int i = 0;
            

            endnumber = int.Parse(Console.ReadLine());

            for(i = startnumber; i<= endnumber; i = i + 1)
            {
                output = output + " x " + i;
                result += i;
            } 
            Console.WriteLine(output + " = " + result);
            }
        }
    
}