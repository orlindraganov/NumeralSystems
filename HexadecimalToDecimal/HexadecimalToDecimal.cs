using System;
using System.Collections.Generic;
using System.Numerics;

class HexadecimalToDecimal
{

    //Dictionary requires System.Collections.Generic
    //BigInteger requires System.Numerics
    static BigInteger ConvertHexToDec(string hex)
    {
        BigInteger dec = 0;
        foreach (char digit in hex)
        {
            dec = hexdecval[digit] + dec * 16;
        }
        return dec;
    }

    static Dictionary<char, int> hexdecval = new Dictionary<char, int>
     {
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'A', 10},
        {'B', 11},
        {'C', 12},
        {'D', 13},
        {'E', 14},
        {'F', 15},
    };


    static void Main()
    {
        string hex = Console.ReadLine();
        Console.WriteLine(ConvertHexToDec(hex));
    }
}
