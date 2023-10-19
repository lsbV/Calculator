using AnalaizerClass;

namespace TestProjectCalcClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static double Add(double a, double b)
        {

            return a + b;
        }
        [TestMethod]
        public static double Substruct(double a, double b)
        {

            return a - b;
        }
        [TestMethod]
        public static double Multiplication(double a, double b)
        {

            return (a * b);
        }
        [TestMethod]
        public static double Divide(double a, double b)
        {

            if (b == 0)
            {
                throw new Exception(MathError.Error09);
            }

            return (a / b);
        }
        [TestMethod]
        public static double Mod(double a, double b)
        {

            if (b == 0)
            {
                throw new Exception(MathError.Error09);
            }

            return a % b;

        }
        [TestMethod]
        public static double ABS(double a)
        {

            return Math.Abs(a);
        }
        [TestMethod]
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
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}