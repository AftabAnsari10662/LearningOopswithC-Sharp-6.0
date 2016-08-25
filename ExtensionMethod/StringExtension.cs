using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {

        public static double ToDouble(this string input)
        {
            double result = double.Parse(input);

            return result;
        }
    }
}
