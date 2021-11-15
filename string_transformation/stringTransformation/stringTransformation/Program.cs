using System;
using System.Text.RegularExpressions;

namespace stringTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            transform("  Hola mundO  ", "UpperCase->LowerCase->SnakeCase");
            Console.ReadKey();

        }

        public static string transform(string phrase, string transformations)
        {
            string[] transf = transformations.Split("->");
            foreach (var t in transf)
            {
                switch (t)
                {
                    case "UpperCase":
                        Console.WriteLine(ConvertToUpperCase(phrase));
                        break;
                    case "LowerCase":
                        Console.WriteLine(ConvertToLowerCase(phrase));
                        break;
                    case "SnakeCase":
                        Console.WriteLine(ConvertToSnakeCase(phrase));
                        break;

                }
            }

            return "Done";
        }


        public static String ConvertToUpperCase(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] >= 'a' && input[i] <= 'z')
                    output += (char)(input[i] - 'a' + 'A');
                else
                    output += input[i];

            }
            return output;
        }

        public static String ConvertToLowerCase(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] >= 'A' && input[i] <= 'Z')
                    output += (char)(input[i] - 'A' + 'a');
                else
                    output += input[i];

            }
            return output;
        }

        public static String ConvertToSnakeCase(String input)
        {
            var formattedString = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (
                    ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z')) &&
                    (input[i + 1] == ' ') &&
                     ((input[i + 2] >= 'A' && input[i + 2] <= 'Z') || (input[i + 2] >= 'a' && input[i + 2] <= 'z')))
                {
                    formattedString[i + 1] = '_';
                }
            }
            return new string(formattedString);
        }

    }
}
