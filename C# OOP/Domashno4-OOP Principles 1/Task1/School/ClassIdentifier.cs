using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    internal static class ClassIdentifier
    {
        private static List<string> classIdentifier = new List<string>();

        public static void Check(string identifier)
        {
            for (int i = 0; i < classIdentifier.Count; i++)
            {
                if (identifier.Trim() == classIdentifier[i])
                {
                    throw new ArgumentException(string.Format("This \"{0}\" class identifier is already assigned!", identifier));
                }
            }
            classIdentifier.Add(identifier);
        }
    }
}