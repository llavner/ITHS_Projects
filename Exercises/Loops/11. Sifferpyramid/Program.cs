namespace _11._Sifferpyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "123456789";

            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(numbers[j]);
                   
                }
                Console.WriteLine();

            }
        }
    }
}
