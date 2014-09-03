using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Task01_Include.TelerikAcademyEntitites;

namespace Task01_Include
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TelerikAcademyEntities();
            string firstResult, secondResult;
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            PrintWithoutInclude(db);
            stopwatch.Stop();
            firstResult = stopwatch.Elapsed.ToString();

            stopwatch.Restart();
            PrintWithInclude(db);
            stopwatch.Stop();
            secondResult = stopwatch.Elapsed.ToString();

            //Here i will do Task 02, because i have a problem with referencing the database in a second project which i cannot resolve.
            //I will be happy if you can give me advice how to do it

            string thirdResult,fourthResult;

            stopwatch.Restart();

            var towns = db.Employees.ToList()
                .Select(emp => emp.Address).ToList()
                .Select(town => town.Town).ToList()
                .Where(town => town.Name == "Sofia");

            stopwatch.Stop();
            thirdResult = stopwatch.Elapsed.ToString();

            stopwatch.Restart();
            towns = db.Employees
                .Select(emp => emp.Address)
                .Select(town => town.Town)
                .Where(town => town.Name == "Sofia");

            stopwatch.Stop();
            fourthResult = stopwatch.Elapsed.ToString();

            Console.WriteLine("without include : " + firstResult);
            Console.WriteLine("with include : " + secondResult);
            Console.WriteLine("Time with ToList: " + thirdResult);
            Console.WriteLine("Time without ToList: " + fourthResult);
        }

        private static void PrintWithoutInclude(TelerikAcademyEntities db)
        {
            foreach (var emp in db.Employees)
            {
                Console.WriteLine("DepartmentID: {0}, {1}, {2}\t {3}", emp.DepartmentID, emp.FirstName, emp.LastName, emp.Address.Town.Name);
            }
        }

        private static void PrintWithInclude(TelerikAcademyEntities db)
        {
            foreach (var emp in db.Employees.Include("Department").Include("Address.Town"))
            {

                Console.WriteLine("DepartmentID: {0}, {1}, {2}\t {3}", emp.DepartmentID, emp.FirstName, emp.LastName, emp.Address.Town.Name);
            }
        }
    }
}
