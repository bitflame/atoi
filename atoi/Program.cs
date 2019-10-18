using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atoi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static int myAtoi(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return 0;
            }
            var result = 0;

            // remove white spaces 
            str = str.Trim();
            // handle positive and negative sign 
            Boolean isNegative = false;
            int startIndex = 0; //index of first numerical character
            try
            {

            }
            catch (ArgumentOutOfRangeException err)
            {
                Console.WriteLine(err.Message);
            }
            if (str.ElementAt(0) == '+' || str.ElementAt(0) == '-')
            {
                startIndex++;
            }
            if (str.ElementAt(0) == '-')
            {
                isNegative = true;
            }
            //handle normal case "123"
            for (int i = startIndex; i < str.Length; i++)
            {
                //Handle non-numerical character
                if (str.ElementAt(i) < '0' || str.ElementAt(i) > '9')
                {
                    break;
                }
                var digitValue = str.ElementAt(i) - '0';//'9' - '0' Gets the ascii value of the digit character
                result = result * 10 + digitValue;
            }
            if (isNegative)
            {
                result = -result;
            }
            //handle out of integer range 
            if (result > Int32.MaxValue)
            {
                return Int32.MaxValue;
            }
            if (result < Int32.MinValue)
            {
                return Int32.MinValue;
            }
            return result;
        }
    }
}
