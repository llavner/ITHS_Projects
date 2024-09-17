namespace _09._Vikt_och_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person newPerson = new Person();

            newPerson.SetName("Marcus", "Renvall");

            newPerson.SetLength(172);
            newPerson.SetWeight(85);

            Console.WriteLine($"Name: { newPerson.GetFullName()}");
            Console.WriteLine($"Length: {newPerson.GetLength()}");
            Console.WriteLine($"Weight: {newPerson.GetWeight()}");

            Console.WriteLine($"BMI: {GetBmi(newPerson.GetWeight(), newPerson.GetLength())}");

        }

        public static double GetBmi(double weight, double length)
        {
            double qLength = length / 100;
            double bodyMassIndex = weight / (qLength * qLength);

            return Math.Round(bodyMassIndex);

        }

        class Person
        {
            private string _fullName;
            private double _weight;
            private double _length;

            public void SetName(string firstName, string lastName)
            {
                _fullName = $"{firstName} {lastName}";
            }

            public string GetFullName()
            {
                return _fullName;
            }

            public void SetLength(double length)
            {
                _length = length;
            }
            public double GetLength()
            {
                return _length;
            }
            public void SetWeight(double weight)
            {
                _weight = weight;
            }

            public double GetWeight()
            {
                return _weight;
            }
        }
    }
}
