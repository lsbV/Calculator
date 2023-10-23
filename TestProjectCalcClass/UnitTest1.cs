using AnalaizerClass;


namespace TestProjectCalcClass
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            double result = AnalaizerClass.CalcClass.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            double result = AnalaizerClass.CalcClass.Add(-5, -3);
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            double result = AnalaizerClass.CalcClass.Add(5, -3);
            Assert.AreEqual(2, result);
        }

        /*[TestMethod]
        public void Add_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Add(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }*/

        [TestMethod]
        public void Substract_PositiveNumbers_ReturnsDifference()
        {
            double result = AnalaizerClass.CalcClass.Substruct(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Substract_NegativeNumbers_ReturnsDifference()
        {
            double result = AnalaizerClass.CalcClass.Substruct(-5, -3);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Substract_PositiveAndNegativeNumbers_ReturnsDifference()
        {
            double result = AnalaizerClass.CalcClass.Substruct(5, -3);
            Assert.AreEqual(8, result);
        }

        /*[TestMethod]
        public void Substract_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Substruct(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }*/

        [TestMethod]
        public void Multiplication_PositiveNumbers_ReturnsProduct()
        {
            double result = AnalaizerClass.CalcClass.Multiplication(5, 3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiplication_NegativeNumbers_ReturnsProduct()
        {
            double result = AnalaizerClass.CalcClass.Multiplication(-5, -3);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Multiplication_PositiveAndNegativeNumbers_ReturnsProduct()
        {
            double result = AnalaizerClass.CalcClass.Multiplication(5, -3);
            Assert.AreEqual(-15, result);
        }

        /*[TestMethod]
        public void Multiplication_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Multiplication(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }*/

        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            double result = AnalaizerClass.CalcClass.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        /*[TestMethod]
        public void Divide_DivideByZero_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Divide(5, 0);
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error09, ex.ErrorCode);
            }
        }
*/
        /*[TestMethod]
        public void Divide_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Divide(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }*/

        [TestMethod]
        public void Mod_PositiveNumbers_ReturnsModulus()
        {
            double result = AnalaizerClass.CalcClass.Mod(10, 3);
            Assert.AreEqual(1, result);
        }

        /*[TestMethod]
        public void Mod_DivideByZero_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Mod(5, 0);
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error09, ex.ErrorCode);
            }
        }*/

        /*[TestMethod]
        public void Mod_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.Mod(2147483648, 2); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }*/

        [TestMethod]
        public void ABS_PositiveNumber_ReturnsPositive()
        {
            double result = AnalaizerClass.CalcClass.ABS(5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ABS_NegativeNumber_ReturnsPositive()
        {
            double result = AnalaizerClass.CalcClass.ABS(-5);
            Assert.AreEqual(5, result);
        }

       /* [TestMethod]
        public void ABS_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.ABS(2147483648); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex);
            }
        }*/

        [TestMethod]
        public void IABS_PositiveNumber_ReturnsNegative()
        {
            double result = AnalaizerClass.CalcClass.IABS(5);
            Assert.AreEqual(-5, result);
        }

        /*[TestMethod]
        public void IABS_NegativeNumber_ReturnsPositive()
        {
            double result = AnalaizerClass.CalcClass.IABS(-5);
            Assert.AreEqual(5, result);
        }*/

        [TestMethod]
        public void IABS_Zero_ReturnsZero()
        {
            double result = AnalaizerClass.CalcClass.IABS(0);
            Assert.AreEqual(0, result);
        }

        /*[TestMethod]
        public void IABS_OutOfRange_ThrowsError()
        {
            try
            {
                AnalaizerClass.CalcClass.IABS(2147483648); // a is out of range
                Assert.Fail("Expected CalcException");
            }
            catch (CalcException ex)
            {
                Assert.AreEqual(MathError.Error06, ex.ErrorCode);
            }
        }*/
    }
}