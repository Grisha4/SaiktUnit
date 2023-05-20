using MathOperations.Lib;
using NUnit.Framework;
namespace MathOperations.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void ShouldPlusTwoNumbers()
        { 
            var calculator = new Calculator();
            var a = 2;
            var b = 3;
            var expected = 5;

            var actual = calculator.Plus(a, b);

            Assert.AreEqual(expected, actual, "Операция сложения");

        }
        [TestCase("1", "2", "3")]
        [TestCase("1", "1", "2")]
        [TestCase("10", "20", "30")]
        public void ShouldPlusNumbersUsingTestCases(int a, int b, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Plus(a, b);

            Assert.AreEqual(expected, actual, "Операция сложения");
        }


        [TestCase("3", "1", "2")]
        public void ShouldMinusNumbersUsingTestCases(int a, int b, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Minus(a, b);

            Assert.AreEqual(expected, actual, "Операция вычитания");
        }


        [TestCase("1", "2", "2")]
        public void ShouldUmnozhitNumbersUsingTestCases(int a, int b, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Umnozhit(a, b);

            Assert.AreEqual(expected, actual, "Операция умножения");
        }


        [TestCase("6", "2", "3")]
        public void ShouldDelitNumbersUsingTestCases(int a, int b, int expected)
        {
            var calculator = new Calculator();

            var actual = calculator.Delit(a, b);

            Assert.AreEqual(expected, actual, "Операция деления");
        }
    }
}