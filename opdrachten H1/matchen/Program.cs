namespace matchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int count = 1;
            int aantal = 10;

            getal= int.Parse(Console.ReadLine());

            while(count <= aantal)
            {

                Console.WriteLine(getal + " ^ " + count + " = " + Math.Pow(getal, count));
                count++;
            }
        }
    }
}