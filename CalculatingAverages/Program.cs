using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages
{
    class Program
    {
        public static void Main(string[] args)
        {


            double a = GetNumber(1);
            double b = GetNumber(2);
            double c = GetNumber(3);
            double d = GetNumber(4);
            double e = GetNumber(5);
            double f = GetNumber(6);
            double g = GetNumber(7);
            double h = GetNumber(8);
            double i = GetNumber(9);
            double j = GetNumber(10);


            Console.WriteLine(Calculator.AddSum(a, b, c, d, e, f, g, h, i, j));
            Console.ReadLine();
        }

        static double GetNumber(double i)
        {

            Console.Write($"Enter 10 differente numbers from 0 to 100 {i}: ");
            double Value = double.Parse(Console.ReadLine());
            if (Value < 0 || 100 < Value)
            {
                Console.WriteLine("you have enter a number that is out of range");
                Console.ReadLine();
            }
            return Value;
        }
        public static class Calculator
        {
            public static double AddSum(double a = 0, double b = 0, double c = 0, double d = 0, double e = 0, double f = 0, double g = 0, double h = 0, double i = 0, double j = 0)
            {
                double x;
                x = (a + b + c + d + e + f + g + h + i + j) / 10;
                return x;
            }

        }

       

        


       

        
        
    }
}
