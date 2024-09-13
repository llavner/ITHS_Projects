using System;

namespace _04._Dölj_vokaler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vokaler = { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
            char[] star = { '*' };
            Console.Write("Skriv in en text: ");
            string input = Console.ReadLine();

            char[] text = input.ToCharArray();

            input = input.Replace(vokaler, star);
            //s = s.Replace("a", "b").Replace("b", "c").Replace("c", "d");
            //"a", "e", "i", "o", "u", "y", "å", "ä", "ö"


        }
    }
}
