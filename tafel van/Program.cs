namespace tafel_van
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tafel = 0;
            int repeat = 1;

            tafel= int.Parse(Console.ReadLine());

            while (repeat <=10) {
                Console.WriteLine(repeat + " x " + tafel + "= " + repeat * tafel);
                repeat++;
            }
        }
    }
}