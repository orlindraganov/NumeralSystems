using System;
using System.Text;
using System.Numerics;
using System.Collections.Generic;


class DecimalToHexadecimal
{

    //Dictionary requires System.Collections.Generic
    //BigInteger requires System.Numerics
    //StringBuilder requires System.Text

    static string ConvertDecToHex(BigInteger dec)
    {
        StringBuilder hex = new StringBuilder();
        do
        {
            hex.Insert(0, dechexval[(int)(dec % 16)]);
            dec = dec / 16;
        }
        while (dec != 0);
        return hex.ToString();
    }

    static Dictionary<int, char> dechexval = new Dictionary<int, char>{
        {0, '0'},
        {1, '1'},
        {2, '2'},
        {3, '3'},
        {4, '4'},
        {5, '5'},
        {6, '6'},
        {7, '7'},
        {8, '8'},
        {9, '9'},
        {10, 'A'},
        {11, 'B'},
        {12, 'C'},
        {13, 'D'},
        {14, 'E'},
        {15, 'F'},
    };


    static void Main()
    {
        BigInteger dec = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecToHex(dec));

    }
}
