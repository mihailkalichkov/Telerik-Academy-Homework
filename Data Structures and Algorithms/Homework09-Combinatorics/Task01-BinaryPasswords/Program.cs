namespace Task01_BinaryPasswords
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

         string passwordPattern = Console.ReadLine();
            var checker = new PasswordChecker();

            ulong asteriksCount = checker.GetPasswordsCountByPattern(passwordPattern);

            Console.WriteLine(asteriksCount);
        }
    }
}
