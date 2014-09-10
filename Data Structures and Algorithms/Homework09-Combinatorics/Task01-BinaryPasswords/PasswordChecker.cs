namespace Task01_BinaryPasswords
{
    using System;
    using System.Linq;

    public class PasswordChecker
    {
        private static readonly char unknownDigitSymbol = '*';

        public ulong GetPasswordsCountByPattern(string passwordPattern)
        {
            ulong asteriksCount = 1;

            for (int i = 0; i < passwordPattern.Length; i++)
            {
                if (passwordPattern[i] == unknownDigitSymbol)
                {
                    asteriksCount *= 2;
                }
            }

            return asteriksCount;
        }
    }
}
