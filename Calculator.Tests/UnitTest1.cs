using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;
        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(12, 14)]
        [InlineData(10, 14)]
        [InlineData(12, 112)]
        public void AddTwoNumbers(double value1, double value2)
        {
            double sum = _calculator.AddNumbers(value1, value2);
            Assert.Equal(sum, (value1 + value2));
        }

        [Theory]
        [InlineData(12, 14)]
        [InlineData(10, 14)]
        [InlineData(12, 112)]
        public void MultiplyTwoNumbers(double value1, double value2)
        {
            double sum = _calculator.MultiplyNumbers(value1, value2);
            Assert.Equal(sum, (value1 * value2));
        }
    }
}
