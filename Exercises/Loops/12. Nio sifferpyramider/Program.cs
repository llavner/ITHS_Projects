﻿namespace _12._Nio_sifferpyramider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "123456789";
            int counter = 0;

            for (int k = 0; k < 9; k++)
            {
                
            
                for (int i = 0; i < numbers.Length; i++)
                {

                    for (int j = 0; j <= i; j++)
                    {
                        if (i == 0 || i >= j || j == 0 || j == i)
                            Console.Write(numbers[j]);

                    }
                    Console.WriteLine();
                    
                }
                
            
            }
        }
    }
}
