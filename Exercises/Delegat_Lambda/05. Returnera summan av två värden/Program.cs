namespace _05._Returnera_summan_av_två_värden
{

    //Skapa ett generiskt delegat med ett lambda uttryck som tar två tal och returnerar summan av dessa.
    //Testa genom att anropa med två värden, och skriva ut resultatet.

    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(add.Invoke(10, 15));

        }
    }
}
