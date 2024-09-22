namespace _09._Bokstavspyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "Hello World";

            for (int i = 0; i < text.Length; i++)
            {

                for (int j = 0; j < text.Length; j++)
                {
                    Console.WriteLine(text[i]);
                }

                Console.WriteLine();
            }
            
        }
    }
}
