using System;
using System.Text;


class BinaryShort
{

    static string ConvertSignedShort(short input)
    {
        StringBuilder bin = new StringBuilder(16);
        for (int i = 0; i < 16; i++)
        {
            bin.Insert(0, (input >> i) & 1);
        }
        return bin.ToString();
    }



    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(ConvertSignedShort(number));
    }
}
