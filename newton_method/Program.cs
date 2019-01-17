using System;

namespace newton_method
{
    class Program
    {
        public static double derivative_f(double x)
        {
            double result;
            result = 240 * Math.Pow(x, 4) + 126 * Math.Pow(x, 2) + 3.5 - 96 * Math.Pow(x, 5) - 224 * Math.Pow(x, 3) - 33 * x;
            return result;
        }
        public static double second_derivative(double x)
        {
            double result;
            result = 12*( -3 * Math.Pow(x, 2) - 5 * Math.Pow(x, 4));
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("for f(x) = 12x - 3x^4 - 2x^6 function");
            Console.Write("please enter the initial point: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double epsilon = 0.00001;
            int count = 1;
            do
            {
                Console.WriteLine("\niteration " + count + "\nx[" + count + "]=" + x);
                if (derivative_f(x) != 0)
                {
                    x = x - derivative_f(x) / second_derivative(x); 
                }
                else
                {
                    break;
                }
                count++;
            }
            while (epsilon < Math.Abs(derivative_f(x)));
            if (epsilon > Math.Abs(derivative_f(x)))
            {
                Console.WriteLine("\niteration " + count + "\nwe can't find the exact x so we assume that x[" + count + "]=" + x);
            }
            Console.ReadKey();
        }
    }
}
