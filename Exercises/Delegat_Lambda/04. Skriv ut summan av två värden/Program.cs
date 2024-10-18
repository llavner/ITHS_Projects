namespace _04._Skriv_ut_summan_av_två_värden
{

    //Skapa ett generiskt delegat med ett lambda uttryck som tar två tal och
    //skriver ut summan av dessa på konsolen. Testa genom att anropa med två värden.
    internal class Program
    {
        static void Main(string[] args)
        {

            Action<int, int> add = (x, y) => Console.WriteLine(x + y);

            add.Invoke(10, 5);
        }
    }
}
