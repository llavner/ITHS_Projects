using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Bil
{
    public class Car
    {

        // Fields
        private string _model;
        private string _color;
        private double _price;

        // Constructors
        public Car()
        {
            Model = string.Empty;
            Color = string.Empty;
            Price = 0;
        }

        public Car(string theModel, string theColor, double thePrice)
        {

            Model = theModel;
            Color = theColor;
            Price = thePrice;
        }

        // Properties
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double HalfPrice()
        {
            double newPrice = Price / 2;
            return newPrice;
        }
    }
}
