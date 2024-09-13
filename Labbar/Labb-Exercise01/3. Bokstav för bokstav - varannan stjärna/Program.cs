namespace _3._Bokstav_för_bokstav___varannan_stjärna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            string myString = "Detta är uppgift 3";
            char myChar = '*';


            for (int i = 0; i < myString.Length; i++)
            {
                result = i % 2 == 0;

                if (result)
                    Console.Write(myChar);
                else
                    Console.Write(myString[i]);
            }
        }
    }
}
