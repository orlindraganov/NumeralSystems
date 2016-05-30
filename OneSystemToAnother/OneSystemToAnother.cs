using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;



class OneSystemToAnother
{
    static string ConvertNumSys(string input, int firstBase, int secondBase)
    {
        StringBuilder output = new StringBuilder();
        BigInteger result = 0;
        foreach (char digit in input)
        {
            int value;
            if (char.IsDigit(digit))
            {
                value = digit - '0';
            }
            else
            {
                value = digit + 10 - 'A';
            }
            result = value + result * firstBase;
        }
        do
        {
            int value = (int)(result % secondBase);
            result = result / secondBase;
            if (value < 10)
            {
                output.Insert(0, value.ToString());
            }
            else
            {
                output.Insert(0, (char)(value - 10 + 'A'));
            }
        } while (result != 0);
        return output.ToString();
    }

    static void Main()
    {
        int firstBase = int.Parse(Console.ReadLine());
        string number = Console.ReadLine().ToUpper();
        int secondBase = int.Parse(Console.ReadLine());
        Console.WriteLine(ConvertNumSys(number, firstBase, secondBase));
    }
}
