namespace tafel_van
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tafel = 0;

            tafel= int.Parse(Console.ReadLine());

            for (int repeat= 0; repeat <=10; repeat++) {
                Console.WriteLine(repeat + " x " + tafel + "= " + repeat * tafel);
            }
        }
    }
}