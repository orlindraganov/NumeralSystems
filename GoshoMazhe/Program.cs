using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(dec);
        }
    }
}