namespace _07._Omvänd_ordning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] strings = new string[7];

            List<string> strings = new List<string>();
            int num = 1;
            
            Console.WriteLine("Skriv in 7 st ord.\n");
            
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"Ord no. {i}: ");

                string input = Console.ReadLine();

                strings.Add(input);
            }

            strings.Reverse();

            foreach (string input in strings)
            {
                Console.WriteLine(input);
            }
        }
    }
}
