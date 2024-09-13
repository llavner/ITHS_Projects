namespace _07._Fylld_box
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

            for (int i = 0; i < pHight; i++)
            {
                for (int j = 0; j < pWidth; j++)
                {

                    Console.Write("X");

                }
                Console.WriteLine();

            }   
        }
    }
}
