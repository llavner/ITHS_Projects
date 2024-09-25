namespace _08._Lägg_till_Print___i_Shape
{


    internal class Program
    {

        //Uppdatera (endast) den abstrakta basklassen med en Print() method.
        //När detta är gjort ska koden nedan...

        //A square with side 3,2 has an area of 10,24 and a circumference of 12,80.
        //A circle with radius 4,5 has an area of 63,62 and a circumference of 28,27.


        static void Main(string[] args)
        {
            var circle = new Circle(5);
            Console.WriteLine(circle);
            Console.WriteLine($"Area: {circle.Area:f2}");
            Console.WriteLine($"Circumference: {circle.Circumference:f2}");

            Console.WriteLine();

            var square = new Square(5);
            Console.WriteLine(square);
            Console.WriteLine($"Area: {square.Area:f2}");
            Console.WriteLine($"Circumference: {square.Circumference:f2}");
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

        public class Square : Shape
        {

            public override double Area { get; }

            public override double Circumference { get; }

            public int Side { get; set; }

            public override string ToString()
            {
                return $"A Square with the side {Side}";
            }


            // Constructor
            public Square(int x)
            {
                Side = x;
                Area = 0;
                Circumference = 0;
            }

        }
    }
}

