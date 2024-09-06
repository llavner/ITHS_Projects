namespace _07._Summa_och_medelvärde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tal = null;
            double parsedTal = 0;
            double sum = 0;
            double counter = 0;
            bool isValid;

            while (tal != "")
            {


                Console.Write("Skriv in ett tal: ");
                tal = Console.ReadLine();
                isValid = double.TryParse(tal, out parsedTal);

                if (isValid)
                {
                    counter++;
                    sum += parsedTal;
                }
                else if (tal == "")
                {
                    //Console.WriteLine("Exit program.");
                    Console.WriteLine();
                    Console.WriteLine($"Summan är: {sum}");
                    Console.WriteLine($"Medelvärdet är: {sum / counter}");
                }
                else
                {
                    Console.WriteLine("Invalid input, try again...");
                    Console.WriteLine();
                }
            }
        }
    }
}
