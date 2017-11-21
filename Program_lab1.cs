using System;

namespace lab_1
{
    public class Complex
    {
        public double re;
        public double im;
    }

    class Program
    {
        static double ReadNumber()
        {
            try
            {
                double num = Convert.ToDouble(Console.ReadLine());
                return num;
            }
            catch (FormatException)
            {
                Console.WriteLine("Совсем не то, попытайся еще раз)");
                return ReadNumber();
            }
        }


        static void Main()
        {
            Console.WriteLine("Введи коэффициенты квадратного уравнения A, B, C:");
            Console.WriteLine("А:");
            double a = ReadNumber();
            Console.WriteLine("В:");
            double b = ReadNumber();
            Console.WriteLine("С:");
            double c = ReadNumber();
            double d = b * b - 4 * a * c;
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("Вот твое решение: x1 = {0}, x2 = {1}", x1, x2);
            }
            else
            {
                Complex x1 = new Complex();
                Complex x2 = new Complex();
                x1.re = -b / 2 * a;
                x1.im = Math.Sqrt(-d) / 2 * a;
                x2.re = x1.re;
                x2.im = -x1.im;
                Console.WriteLine("Вот твое решение: {0}+{1}i, {2}-{3}i", x1.re, x1.im, x2.re, x2.im);
            }

        }
    }
}
