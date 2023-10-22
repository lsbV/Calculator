using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalaizerClass
{
    public class CalcClass
    {
        public static double Add(double a, double b)
        {
            if ((a < -2147483647 || a > 2147483647) || (b < -2147483647 || b > 2147483647))
            {
                throw new CalcException(MathError.Error06);
            }

            return a + b;

        }
        public static double Substruct(double a, double b)
        {
            if ((a < -2147483647 || a > 2147483647) || (b < -2147483647 || b > 2147483647))
            {
                throw new CalcException(MathError.Error06);
            }


            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            if ((a < -2147483647 || a > 2147483647) || (b < -2147483647 || b > 2147483647))
            {
                throw new CalcException(MathError.Error06);
            }


            return (a * b);
        }
        public static double Divide(double a, double b)
        {
            if ((a < -2147483647 || a > 2147483647) || (b < -2147483647 || b > 2147483647))
            {
                throw new CalcException(MathError.Error06);
            }

            if (b == 0)
            {
                throw new CalcException(MathError.Error09);
            }

            return (a / b);
        }
        public static double Mod(double a, double b)
        {
            if ((a < -2147483647 || a > 2147483647) || (b < -2147483647 || b > 2147483647))
            {
                throw new CalcException(MathError.Error06);
            }

            if (b == 0)
            {
                throw new CalcException(MathError.Error09);
            }

            return a % b;

        }
        public static double ABS(double a)
        {
            if (a < -2147483647 || a > 2147483647)
            {
                throw new CalcException(MathError.Error06);
            }

            return Math.Abs(a);
        }
        public static double IABS(double a)
        {
            if (a < -2147483647 || a > 2147483647)
            {
                throw new CalcException(MathError.Error06);
            }


            if (a > 0)
            {
                return -a;
            }
            return a;


        }
        private static string _lastError = "";
        public static string LastError
        { get { return _lastError; } }

    }
}
