namespace _06._Egen_version_av_String.Join___
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MyJoin('-', "Sweden", "Finland", "Norway", "Denmark", "Iceland"));

            static string MyJoin(char separator, params string[] countries)
            {
                string newString = string.Empty;
                bool lastEntry = false;

                foreach (string item in countries)
                {

                    if (lastEntry)
                    {
                        newString += separator + item;
                    }
                    else
                        newString += item;
                        lastEntry = true;
                }

                return newString;
            }

        }
    }
}
