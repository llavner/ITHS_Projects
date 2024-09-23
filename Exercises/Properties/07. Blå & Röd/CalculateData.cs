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
        public double sum = 100;

        
        public double Red 
        {
            get { return _red; }


            set 
            {
                if (value < 0)
                    _red = 0;
                else if (value > 100)
                    _red = 100;
                else
                    _red = value;
            }

        }

        public double Blue
        {
            get { return _blue; }


            set
            {
                if (value < 0)
                    _blue = 0;
                else if (value > 100)
                    _blue = 100;
                else
                    _blue = value;

            }

        }

        


    }
}
