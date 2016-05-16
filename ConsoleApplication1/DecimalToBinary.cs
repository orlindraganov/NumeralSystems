using System;
using System.Text;
using System.Numerics;



class DecimalToBinary
{

    //StringBuilder requires System.Text
    //BigInteger requires System.Numerics
    static string ConvertDecToBin(BigInteger dec)
    {
        StringBuilder bin = new StringBuilder();
        do
        {
            bin.Insert(0, dec % 2);
            dec = dec / 2;
        }
        while (dec != 0);

        return bin.ToString();
    }

    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecToBin(number));
    }
}
