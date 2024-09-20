using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1,2); 
            Complex c2 = new Complex(3,1);
            Complex c3 = c1.Plus(c2);
            Console.WriteLine($"{c3.Real.ToString()}, {c3.Imag.ToString()}");
            Complex c4 = c1.Minus(c2);
            Console.WriteLine($"{c4.Real.ToString()}, {c4.Imag.ToString()}");
            Console.ReadKey();
        }
    }
    public class Complex
    {
        private double _real;
        private double _imag;

        public double Real
        {
            get { return _real; }
            private set { _real = value; }
        }
        public double Imag 
        {
            get { return _imag; }
            private set { _imag = value; }
        }
        private Complex()
        {
        }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imag = imaginary;
        }
        public Complex Plus (Complex c)
        {
            var sum = new Complex(c.Real + Real, c.Imag + Imag);
            return sum ;
        }
        public Complex Minus(Complex x)
        {
            var minus = new Complex(Real - x.Real, Imag - x.Imag);
            return minus;
        }
    }
}
