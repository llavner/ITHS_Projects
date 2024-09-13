namespace _06._Riskorn_på_shackbräde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                ulong sum = 1;

                for (int i = 1; i <= 64; i++)
                {


                    Console.WriteLine($"Ruta {i}: {sum}");
                    sum += sum;
                }
            }
        }
    }
}
