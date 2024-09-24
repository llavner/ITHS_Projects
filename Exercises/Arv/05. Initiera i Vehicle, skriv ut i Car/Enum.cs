using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Initiera_i_Vehicle__skriv_ut_i_Car_
{

    enum Brand
    {
        Volvo,
        BMW,
        Saab,
        Dodge
    }

    enum Color
    {
        Red,
        Blue,
        Green,
        Brown,
        Yellow

    }

    public struct Size
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
}
