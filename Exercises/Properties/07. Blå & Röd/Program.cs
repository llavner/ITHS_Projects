namespace _07._Blå___Röd
{
    internal class Program
    {

        //Skapa en en klass som har en property “Red” och en property “Blue”.

        //Båda ska vara en double och kunna ha ett värde mellan 0.0 och 100.0 men de ska vara “sammankopplade”
        //på så vis att värdena tillsammans alltid är 100.0 d.v.s om man t.ex.sätter “Blue” till 8.5 och sedan läser av “Red” så ska den returnera 91.5

        static void Main(string[] args)
        {

            var myCalc = new CalculateData();

            myCalc.Red = 54.3;

            Console.WriteLine($"When Blue is {Math.Round(myCalc.Blue, 1)} Red is {Math.Round(myCalc.Red, 1)}");








        }
    }
}
