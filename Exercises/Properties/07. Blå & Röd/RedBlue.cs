using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Blå___Röd
{
    public class RedBlue
    {

		private double _blue;
        private double _red;
		public double sum = 100;


        public double Blue
		{
			get { return _blue; }
			set { _blue = value - sum; }
		}

		public double Red
		{
			get { return _red; }
			set { _red = value - sum ; }
		}

	}
}
