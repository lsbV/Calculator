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
            return a + b;
        }
        public static double Substruct(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a,double b)
        {
            return (a * b);
        }
        public static double Divide(double a,double b) 
        {
            if (b==0)
            {
                throw  new Exception("Divide by zero");   
            }
            return (a / b);
        }
        public static double Mod(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Divide by zero");
            }
            return a % b;
            
        }
        public static double ABS(double a) 
        {
            return Math.Abs(a);
        }
        public static int IABS(int a) 
        {
            if (a is double)
            {
                throw new Exception("Wrong format");
            }
            return Math.Abs((int)a);
        }
        private static string _lastError = "";
        public static string LastError
        { get { return _lastError; } }

    }
}
