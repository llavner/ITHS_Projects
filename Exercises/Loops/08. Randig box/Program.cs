namespace _08._Randig_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in höjd: ");
            string hight = Console.ReadLine();
            int pHight = Int32.Parse(hight);

            Console.Write("Mata in bredd: ");
            string width = Console.ReadLine();
            int pWidth = Int32.Parse(width);

            for (int i = 1; i <= pHight; i++)
            {
                for (int j = 1; j <= pWidth; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("O");
                    else
                        Console.Write("X");
                }

                Console.WriteLine();
            }
        }
    }
}
