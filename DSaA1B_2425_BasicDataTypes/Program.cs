using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSaA1B_2425_BasicDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Declarations
            // <dt> <vn> = <initial value>
            byte a = 1;

            short b = 1;
            int c = 1;
            long d = 1;

            float e = 1f;
            double f = 1d;

            char g = 'g';

            bool h = true;
            h = false;

            string i = "";
            i = string.Empty;
            #endregion

            b = a;
            c = a;
            d = a;
            e = a;
            f = a;


            // implied casting
            int x = 65;
            char y = (char)x;
            Console.WriteLine(y + "");
            x = y + 32;
            Console.WriteLine((char)x + "");

            string thing = "Southville";

            for (int z = 0; z < thing.Length; z++)
            {
                Console.Write((int)thing[z] + " ");
            }

            Console.WriteLine();

            e = 5.0006f;
            f = 5.0006d;

            Console.WriteLine($"{e}");
            Console.WriteLine($"{f}");

            string thing2 = "";
            for (int z = thing.Length - 1; z > -1; z--)
            {
                thing2 += thing[z];
            }

            Console.WriteLine(thing2);

            string thing4 = "";
            char[] thing3 = { 'a', 'b', 'c' };
            for(int z = 0; z < thing3.Length; z++)
                thing4 += thing3[z];

            Console.WriteLine(thing4);

            Console.ReadKey();
        }
    }
}
