using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Blå___Röd
{
    public class CalculateData
    {

        // Properties

        private double _red;
        private double _blue;
        //public double sum = 100;


        public double Red
        {
            get { return _red; }

            set
            {
                 _red = Math.Clamp(value, 0, 100);
                if (_red < 100)
                {
                    _red = 100 - _red;
                    _blue = 100 - _red;
                }
            }
        }

        public double Blue
        {
            get { return _blue; }

            set
            {
                _blue = Math.Clamp(value, 0, 100);
                if (_blue < 100)
                {
                    Blue = 100 - Blue;
                    Red = 100 - Blue;
                }
            }
        }

        



    }
}
