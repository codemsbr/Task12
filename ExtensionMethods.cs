using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    static class ExtensionMethods
    {
        public static bool IsPrime(this int number)
        {
            #region Yol 1
            //for (int i = 2; i <= Math.Sqrt(number); i++)
            //{
            //    if (number % i == 0)
            //        return true;
            //}
            return false;
            #endregion

            int halfValue = number / 2;
            for (int i = 2; i <= halfValue; i++)
            {
                if (number % i == 0)
                    return true;
            }
            return false;
        }

        public static bool IsPowOfTwo(this int number)
        {
            while (number%2 == 0)
            {
                number /= 2;
                if (number == 1)
                    return true;
            }
            return false;
        }
    }
}
