namespace _04._Stegräknare
{
    internal class Program
    {

        //Skapa en klass som kan användas som stegräknare. Den ska ha en property "Steps" som bara går att läsa; en metod Step()
        //som räknar upp Steps med 1 varje gång man anropar den; och en metod Reset() som nollställer räknaren.
        //Instantiera klassen och skriv en loop som motsvarar att man går 1000 steg.Skriv ut värdet på Steps.
        static void Main(string[] args)
        {
            StepCounter mySteps = new StepCounter();

            do
            {
                mySteps.Step();
                Console.WriteLine($"Mina steg är: { mySteps.Steps}");

            } while (mySteps.Steps != 1000);
            

            
        }
    }
}
 