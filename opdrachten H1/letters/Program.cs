namespace letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hoi";

            text = Console.ReadLine();
            char teken = char.Parse(Console.ReadLine());

            char spat = char.Parse(" ");

            char [] text1 = text.ToCharArray();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            Console.WriteLine(text1[2]);

            foreach (char c in text1) {
                if (c == teken)
                {
                    count1++;
                }
                if (c == spat)
                {
                    count2++;
                }
                if (c == 'a' || c == 'e' || c == 'u' || c == 'i' || c == '0')
                {
                    count3++;
                }else
                {
                    count4++;
                }
            }

            Console.WriteLine(count1 + " " + count2 + " " + count3 + " " + count4 );






        }
    }
}