namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temp = { -40,-33,-22,-11,-1,10,20,22,28,32,35,38,39,40,50};

            int[] prijzen = { 0, 200, 400, 1000, 100000 };

            string[] namen = { "jan", "piet", "karel", "jan2" };

            Console.WriteLine(temp[6]);
            Console.WriteLine(namen[0]);

            int regelnummer = 0;
            try
            {
                regelnummer = int.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("er is een fout opgetreden");
            }

            Console.WriteLine(regelnummer + ": " + namen[regelnummer]);
            
            int[] getallen = {10,20,30,40,50,60,70,80,90,100 };
            int plus = 0;
            regelnummer = int.Parse(Console.ReadLine());
            plus= int.Parse(Console.ReadLine());
            Console.WriteLine(getallen[regelnummer] + plus);

            regelnummer = int.Parse(Console.ReadLine());
            Console.WriteLine(temp[regelnummer] * prijzen[regelnummer]);

            int index = 1;
            int lengtearray = getallen.Length;
            string uitvoer = getallen[0].ToString();

            while (index < lengtearray)
            {
                uitvoer = uitvoer + "," + getallen[index].ToString();
                index++;
            }
            Console.WriteLine(uitvoer);

            uitvoer = getallen[0].ToString();

            for (index=1;index<lengtearray;index++)
            {
                uitvoer = uitvoer + "," + getallen[index].ToString();
            }
            Console.WriteLine(uitvoer);

            string uitvoer1 = "";
            uitvoer = getallen[0].ToString();

            foreach (int getal in getallen)
            {
                uitvoer = uitvoer + "," + getal.ToString();
            }
            Console.WriteLine(uitvoer);

            Array.Resize(ref prijzen, 10);

            prijzen.SetValue(value: 2000, index: 6);
            prijzen.SetValue(value: 2070, index: 7);
            prijzen.SetValue(value: 2200, index: 8);
            prijzen.SetValue(value: 2300, index: 9);

            uitvoer = prijzen[0].ToString();

            foreach (int prijs in prijzen)
            {
                uitvoer = uitvoer + "," + prijs.ToString();
            }
            Console.WriteLine(uitvoer);

        }

    }
}