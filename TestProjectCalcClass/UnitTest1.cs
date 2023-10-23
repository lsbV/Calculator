using AnalaizerClass;

namespace TestProjectCalcClass
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            double result = Calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            double result = Calculator.Add(-5, -3);
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            double result = Calculator.Add(5, -3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Add_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.Add(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void Substract_PositiveNumbers_ReturnsDifference()
        {
            double result = Calculator.Substract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Substract_NegativeNumbers_ReturnsDifference()
        {
            double result = Calculator.Substract(-5, -3);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Substract_PositiveAndNegativeNumbers_ReturnsDifference()
        {
            double result = Calculator.Substract(5, -3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Substract_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.Substract(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void Multiplication_PositiveNumbers_ReturnsProduct()
        {
            double result = Calculator.Multiplication(5, 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiplication_NegativeNumbers_ReturnsProduct()
        {
            double result = Calculator.Multiplication(-5, -3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiplication_PositiveAndNegativeNumbers_ReturnsProduct()
        {
            double result = Calculator.Multiplication(5, -3);
            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        public void Multiplication_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.Multiplication(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            double result = Calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_DivideByZero_ThrowsError()
        {
            try
            {
                Calculator.Divide(5, 0);
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error09, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void Divide_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.Divide(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void Mod_PositiveNumbers_ReturnsModulus()
        {
            double result = Calculator.Mod(10, 3);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Mod_DivideByZero_ThrowsError()
        {
            try
            {
                Calculator.Mod(5, 0);
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error09, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void Mod_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.Mod(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void ABS_PositiveNumber_ReturnsPositive()
        {
            double result = Calculator.ABS(5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ABS_NegativeNumber_ReturnsPositive()
        {
            double result = Calculator.ABS(-5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ABS_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.ABS(2147483648); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }

        [TestMethod]
        public void IABS_PositiveNumber_ReturnsNegative()
        {
            double result = Calculator.IABS(5);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void IABS_NegativeNumber_ReturnsPositive()
        {
            double result = Calculator.IABS(-5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void IABS_Zero_ReturnsZero()
        {
            double result = Calculator.IABS(0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void IABS_OutOfRange_ThrowsError()
        {
            try
            {
                Calculator.IABS(2147483648); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }
    }
}