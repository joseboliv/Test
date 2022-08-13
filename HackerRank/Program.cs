using System;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 5;
            int inputnumbers = 0;
            Console.Write("Inserte longitud de caracteres \n");
            string inputIterationNumber = Console.ReadLine();
            arrayLength = inputIterationNumber.ConvertStringToInteger();

            Console.Write("Inserte Valor Bit:\n");
            string inputValuesNumber = Console.ReadLine().Replace(" ", string.Empty);
            //string inputValuesNumber = "1 2 1 2 4".Replace(" ", string.Empty);
            inputnumbers = Convert.ToInt32(inputValuesNumber);

            int cant = 0;
            int number = 0;
            if (arrayLength > 1)
            {
                for (int i = 0; i < inputValuesNumber.Length; i++)
                {
                    int aux = int.Parse(inputValuesNumber[i].ToString());
                    int auxCount = 0;

                    for (int j = 0; j < inputValuesNumber.Length; j++)
                    {
                        int g = int.Parse(inputValuesNumber[j].ToString());
                        if (aux == int.Parse(inputValuesNumber[j].ToString()))
                        {
                            auxCount++;
                        }
                    }

                    if (i == 0)
                    {
                        number = aux;
                        cant = auxCount;
                    }
                    else if (cant > auxCount)
                    {
                        cant = auxCount;
                        number = aux;
                    }
                }
            }
            inputnumbers = number;
            Console.WriteLine($"{inputnumbers}");
            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static int ConvertStringToInteger(this string value)
        {
            int aux = 0;
            int.TryParse(value, out aux);
            return aux;
        }

        public static void PrintResult(this string[] value)
        {
            foreach (var item in value)
            {
                Console.WriteLine(Convert.ToUInt64(item, 2));
            }
        }

    }
}
