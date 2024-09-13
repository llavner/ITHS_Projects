namespace _09._Bokstavspyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello, World!";

            for (int i = 0; i < myString.Length ; i++)
            {
                

                for (int j = 0; j < i + 1; j++) // "j < i + 1" Säkerhetställer att den inre loopen körs en gång mer än värdet på i
                {

                    Console.Write(myString[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
