﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task01_SortedDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\students.txt";

            var sortedCoursesWithStudents = GetSortedCoursesWithStudents(filePath);

            foreach (var course in sortedCoursesWithStudents)
            {
                string line = "";
                foreach (var student in course.Value)
                {
                    line += string.Format("{0} {1}, ", student.Value, student.Key);
                }
                Console.WriteLine("{0}: {1}", course.Key, line.Substring(0, line.Length - 2));
            }
    
        }

        private static SortedDictionary<string, SortedDictionary<string, string>> GetSortedCoursesWithStudents(string path)
        {
            var dictionary = new SortedDictionary<string, SortedDictionary<string, string>>();
            string line;

            var file = new StreamReader(path);

            while ((line =file.ReadLine()) != null)
            {
                int borderIndex = line.IndexOf('|');
                string firstName = line.Substring(0, borderIndex).TrimEnd();
                int secondBorderIndex = line.IndexOf('|', borderIndex + 1);
                string lastName = line.Substring(borderIndex + 1, secondBorderIndex - borderIndex - 1).Trim();
                string course = line.Substring(secondBorderIndex + 1).Trim();

                if (!dictionary.ContainsKey(course))
                {
                    var sortedStudents = new SortedDictionary<string, string>();
                    sortedStudents.Add(lastName, firstName);
                    dictionary[course] = sortedStudents;
                }
                else
                {
                    dictionary[course][lastName] = firstName;
                }
            }
            return dictionary;
        }
    }
}
