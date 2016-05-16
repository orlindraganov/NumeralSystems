using System;
using System.Numerics;
using System.Collections.Generic;



class BinaryToDecimal
{
    //BigInteger requires System.Numerics
    static BigInteger ConvertBinToDec(string bin)
    {
        BigInteger sum = 0;
        foreach (char bit in bin)
        {
            sum = bit - '0' + sum * 2;
        }
        return sum;
    }

    static void Main()
    {
        string bin = Console.ReadLine();
        Console.WriteLine(ConvertBinToDec(bin));
    }
}
