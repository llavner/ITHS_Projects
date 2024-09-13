namespace _03._Kolla_om_stängen_är_längre_än_ett_givet_antal_tecken_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLonger = CheckString("Hallå!", 10);

            if (isLonger)
                Console.WriteLine($"Texten är längre = {isLonger}");
            else
                Console.WriteLine($"Texten är kortare = {isLonger}");
            
        }

        static bool CheckString(string text, int letters)
        {
            if (text.Length > letters)
                return true;
            else
                return false;
        }
    }
}
