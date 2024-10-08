﻿using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _06._Circle_som_ärver_från_Shape
{
    internal class Program

    //A circle with radius 5
    //Area: 78,54
    //Circumference: 31,42
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            Console.WriteLine(circle);
            Console.WriteLine($"Area: {circle.Area:f2}");
            Console.WriteLine($"Circumference: {circle.Circumference:f2}");

        }

        public abstract class Shape
        {
            public abstract double Area { get; }
            public abstract double Circumference { get; }
        }

        public class Circle : Shape
        {

            public override double Area { get; }

            public override double Circumference { get; }

            public int Radius { get; set; }

            public override string ToString()
            {
                return $"A circle with the radius {Radius}";
            }


            // Constructor
            public Circle(int x)
            {
                Radius = x;
                Area = Math.PI * Math.Pow(x, 2);
                Circumference = Math.PI * (x * 2);
            }

        }
    }
}
