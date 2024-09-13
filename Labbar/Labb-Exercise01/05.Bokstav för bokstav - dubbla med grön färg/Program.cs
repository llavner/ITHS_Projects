using System;
using System.ComponentModel.Design;
using System.Net.WebSockets;
using static System.Net.Mime.MediaTypeNames;

namespace _05.Bokstav_för_bokstav___dubbla_med_grön_färg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello, World!";

            for (int i = 0; i < myString.Length; i++) 
            {
                if (i > 0 && myString[i] == myString[i - 1]) // Kontrollera bokstaven innan Index
                    Console.ForegroundColor = ConsoleColor.Green;
                
                else if (i != myString.Length - 1 && myString[i] == myString[i + 1]) // Kontrollerar bokstaven efter Index & i != 
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;


                Console.Write(myString[i]);

                    Console.ForegroundColor = ConsoleColor.Gray;

            }
        }
    }
}
            


    

