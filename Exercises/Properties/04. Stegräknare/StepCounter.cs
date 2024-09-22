using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Stegräknare
{
    public class StepCounter
    {
		private int _steps;

		public int Steps
		{
			get { return _steps; }
			//set { _steps = value; }
		}

		public void Step()
		{
			_steps++;

		}

		public void ResetCounter()
		{
			_steps = 0;
		}

	}
}
