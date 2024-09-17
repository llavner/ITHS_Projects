namespace _05._Lägg_in_bindesträck_mellan_tecken_i_en_sträng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en text: ");
            string text = Console.ReadLine();

            Console.WriteLine(StringManipulation(text));
        }
        static string StringManipulation(string text)
        {
            char[] textArray = text.ToCharArray();
            string result = string.Join("-", textArray);
            return result.ToString();
        }
    }
}



