using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Maths
    {
        public static int Add(int num1, int num2)
        {
            return(num1 + num2);
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return(num1 + num2);
        }
        public static string Add(int num1, int num2, bool check)
        {
            var solution = num1 + num2;

            if (check == true && solution > 1)
            {
                return $"{solution} dollars";
            }
            else if (check == true && solution == 1)
            {
                return $"{solution} dollar";
            }
            else if (check == true && solution < 1)
            {
                return $"{solution} dollars";
            }
            else
            {
                return solution.ToString();
            }

        }

    }
}
