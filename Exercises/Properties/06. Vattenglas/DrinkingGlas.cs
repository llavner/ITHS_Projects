using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Vattenglas
{
    internal class DrinkingGlas
    {

		private bool _isFull;

		public bool IsFull
		{
			get { return _isFull; }
			set { _isFull = value; }
		}

		private bool _isBroken;

		public bool IsBroken
		{
			get { return _isBroken;; }
			set { _isBroken = value; }
		}


		public void FillGlas()
		{
			

			if (IsBroken)
                Console.WriteLine("The glas is broken, can't refill.");
			else if (IsFull)
                Console.WriteLine("Already full.");
			else
                Console.WriteLine("Filling...");
			IsFull = true;
		}

		public void EmptyGlas()
		{
            if (IsBroken)
                Console.WriteLine("The glas is broken and already empty.");
			else if (IsFull)
                Console.WriteLine("Emptying...");
            else 
				Console.WriteLine("Already empty.");
			IsFull = false;
		}

		public void BreakGlas()
		{
			IsBroken = true;
			if(IsBroken)
                Console.WriteLine("The glas is crushed to pieces.");
			
		}

		public DrinkingGlas()
		{

			IsFull = false;
			IsBroken = false;

		}




	}
}
