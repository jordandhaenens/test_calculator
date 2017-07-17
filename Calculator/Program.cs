using System;

namespace Calculator
{
    public class Calculator
    {
        private double _sum;
        public double AddNumbers(double value1, double value2)
        {
            _sum = value1 + value2;
            return _sum;
        }
        public double MultiplyNumbers(double value1, double value2)
        {
            _sum = value1 * value2;
            return _sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
