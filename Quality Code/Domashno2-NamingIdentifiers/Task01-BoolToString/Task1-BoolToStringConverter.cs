namespace Refactoring
{
    using System;

    public class Converter
    {
        public static void Main(string[] args)
        {
            Converter.BoolConverter converter =
              new Converter.BoolConverter();

            converter.PrintBoolToString(true);
        }

        public class BoolConverter
        {
            public void PrintBoolToString(bool boolVar)
            {
                string boolVarToString = boolVar.ToString();

                Console.WriteLine(boolVarToString);
            }
        }
    }
}