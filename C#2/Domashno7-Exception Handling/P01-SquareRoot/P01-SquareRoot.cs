using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SquareRoot
{
    class Program
    {
        static void Main()
        {
            try
            {
                uint n = uint.Parse(Console.ReadLine());

                Console.WriteLine(Math.Sqrt(n));
            }

            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}