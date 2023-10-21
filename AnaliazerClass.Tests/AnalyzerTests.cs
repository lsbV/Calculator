using AnalaizerClass;

namespace AnalyzerClass.Tests
{
    [TestClass]
    public class AnalyzerTests
    {
        [TestMethod]
        public void TestEstimate_NormalWork()
        {
            string expression = "5 - (4 - 3) * (4 + (2 * 3) - (2 - 1))";
            Analyzer analyzer = new Analyzer(expression);
            var extended = -4;
            var actual = analyzer.Estimate();
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void TestEstimate_SimilarBrackets()
        {
            string expression = "(3+3)*(3+3)";
            Analyzer analyzer = new Analyzer(expression);
            var extended = 36;
            var actual = analyzer.Estimate();
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(CalcException))]
        public void TestEstimate_IncorrectBrackets()
        {
            string expression = "5-((2+1)";
            Analyzer analyzer = new Analyzer(expression);
            var actual = analyzer.Estimate();
        }

        [TestMethod]
        [ExpectedException(typeof(CalcException))]
        public void TestEstimate_IncorrectOperators()
        {
            string expression = "5**2";
            Analyzer analyzer = new Analyzer(expression);
            var actual = analyzer.Estimate();
        }

        [TestMethod]
        public void TestEstimate_FloatNumbers()
        {
            string expression = "1,5+3.1";
            Analyzer analyzer = new Analyzer(expression);
            var extended = 4.6;
            var actual = analyzer.Estimate();
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void TestEstimate_UnaryMinus()
        {
            string expression = "5 - -4";
            Analyzer analyzer = new Analyzer(expression);
            var extended = 9;
            var actual = analyzer.Estimate();
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void TestEstimate_CheckPriority()
        {
            string expression = "5 - -4 * 2 + 2 / 2 * 2";
            Analyzer analyzer = new Analyzer(expression);
            var extended = 15;
            var actual = analyzer.Estimate();
            Assert.AreEqual(extended, actual);
        }
    }
}