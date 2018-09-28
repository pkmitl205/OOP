using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    // Encapsulation

    class CelsiusToFahrenheit
    {
        private double celsius;

        public double Celsius
        {
            set { celsius = value; }
        }

        public double MakeFahrenhit()
        {
            return (celsius * 9 / 5) + 32;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CelsiusToFahrenheit myCTOF = new CelsiusToFahrenheit();
            myCTOF.Celsius = 37;
            Console.WriteLine(myCTOF.MakeFahrenhit());
            Console.ReadLine();
        }
    }
}
