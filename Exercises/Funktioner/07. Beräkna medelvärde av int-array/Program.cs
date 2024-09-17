namespace _07._Beräkna_medelvärde_av_int_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MedianNum(10, 20, 40, 60));

        }

        public static double MedianNum(params int[] intNumbers)
        {
            int counter = 0;
            double sum = 0;
            double average = 0;
            

            foreach (var item in intNumbers)
            {
                sum += item;
                counter++;
            }

            average = sum / counter;

            return average;

        }
    }
}
