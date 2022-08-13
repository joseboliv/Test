using System;

namespace HackerRank
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int iterationNumber = 1;
    //        int length = 32;
    //        char pad = '0';
    //        Console.Write("Inserte cantidad de iteraciones \n");
    //        string inputIterationNumber = Console.ReadLine();
    //        iterationNumber = inputIterationNumber.ConvertStringToInteger();
            
    //        string[] finishResult = new string[iterationNumber];

    //        for (int i = 0; i < iterationNumber; i++)
    //        {
    //            string binary = string.Empty;
    //            int remainder;
    //            Console.Write("Inserte Valor Bit:\n");
    //            string aux = Console.ReadLine();
    //            int inputInteger = aux.ConvertStringToInteger();

    //            while (inputInteger > 0)
    //            {
    //                remainder = inputInteger % 2;
    //                inputInteger /= 2;
    //                binary = remainder.ToString() + binary;
    //            }

    //            if (binary.Length < length)
    //            {
    //                binary = binary.PadLeft(length, pad);
    //            }

    //            string[] complete = new string[binary.Length];

    //            for (int j = 0; j < binary.Length; j++)
    //            {
    //                if (binary[j].ToString() == "1")
    //                {
    //                    complete[j] = "0";
    //                }
    //                else
    //                {
    //                    complete[j] = "1";
    //                }
    //            }
    //            binary = string.Join("", complete);
    //            finishResult[i] = binary;
    //        }
    //        finishResult.PrintResult();
    //    }
    //}

    //public static class Extensions
    //{
    //    public static int ConvertStringToInteger(this string value)
    //    {
    //        int aux = 0;
    //        int.TryParse(value, out aux);
    //        return aux;
    //    }

    //    public static void PrintResult(this string[] value)
    //    {
    //        foreach (var item in value)
    //        {
    //            Console.WriteLine(Convert.ToUInt64(item, 2));
    //        }
    //    }

    //}
}
