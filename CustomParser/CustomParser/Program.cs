
using System;

namespace CustomTryParse
{


    class Program
    {

        static public int? CustomTryParse(string valueToParse, out bool isParsableAndNegative)
        {


            if (int.TryParse(valueToParse, out int parsedValue) && parsedValue < 0)
            {
                isParsableAndNegative = true;
                return parsedValue;

            }
            else
            {
                isParsableAndNegative = false;
                return null;
            }



        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a number to parse: ");
                string value = Console.ReadLine();
                bool isParsableAndNegative;
                CustomTryParse(value, out isParsableAndNegative);
                Console.WriteLine($"Value: {value}");
                Console.WriteLine($"Is Parsable and nagative number?: {isParsableAndNegative}");
                Console.WriteLine("-----------------------------------------------------\n");
            }




        }

    }
}