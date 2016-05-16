using System;
using System.Collections.Generic;
using System.Text;

class HexadecimalToBinary
{
    //Dictionary requires System.Collections.Generic
    //Stringbuilder requires System.Text
    static string ConvertHexToBin(string hex)
    {
        StringBuilder bin = new StringBuilder();
        foreach (char digit in hex)
        {
            bin.Append(hexdecval[digit]);
        }
        string output = bin.ToString().TrimStart('0');
        if (output == "")
        {
            return "0";
        }
        else
        {
            return bin.ToString().TrimStart('0');
        }
    }

    static Dictionary<char, string> hexdecval = new Dictionary<char, string>
     {
        {'0', "0000"},
        {'1', "0001"},
        {'2', "0010"},
        {'3', "0011"},
        {'4', "0100"},
        {'5', "0101"},
        {'6', "0110"},
        {'7', "0111"},
        {'8', "1000"},
        {'9', "1001"},
        {'A', "1010"},
        {'B', "1011"},
        {'C', "1100"},
        {'D', "1101"},
        {'E', "1110"},
        {'F', "1111"},
    };


    static void Main()
    {
        string hex = Console.ReadLine();
        Console.WriteLine(ConvertHexToBin(hex));
    }
}