using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
           Console.WriteLine("Sum = "+calculator.sum(1, 2));
        }
    }
    class Calculator
    {
        public int sum(int a, int b)
        { 
        return a + b;
        }
    }
}
