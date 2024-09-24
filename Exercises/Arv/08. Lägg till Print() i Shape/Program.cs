namespace _08._Lägg_till_Print___i_Shape
{


    internal class Program
    {

        static void Main(string[] args)
        {


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

