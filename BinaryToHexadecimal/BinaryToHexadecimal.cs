using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
    static Dictionary<string, char> binhexval = new Dictionary<string, char>{
        {"0000", '0'},
        {"0001", '1'},
        {"0010", '2'},
        {"0011", '3'},
        {"0100", '4'},
        {"0101", '5'},
        {"0110", '6'},
        {"0111", '7'},
        {"1000", '8'},
        {"1001", '9'},
        {"1010", 'A'},
        {"1011", 'B'},
        {"1100", 'C'},
        {"1101", 'D'},
        {"1110", 'E'},
        {"1111", 'F'},
    };

    static string ConvertBinToHex(string binary)
    {
        StringBuilder bin = new StringBuilder(binary);
        while (bin.Length % 4 != 0)
        {
            bin.Insert(0, '0');
        }
        StringBuilder word = new StringBuilder(4);
        StringBuilder hex = new StringBuilder(16);
while (bin.Length != 0)
            {
            word.Clear();
            word.Append(bin[bin.Length - 4]);
            word.Append(bin[bin.Length - 3]);
            word.Append(bin[bin.Length - 2]);
            word.Append(bin[bin.Length - 1]);
            hex.Insert(0, binhexval[word.ToString()]);
            bin.Remove(bin.Length - 4, 4);
        }
        return hex.ToString();
    }

    static void Main()
    {
        string bin = Console.ReadLine();
        Console.WriteLine(ConvertBinToHex(bin));
    }
}
