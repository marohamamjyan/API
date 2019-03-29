using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        int real, imaginary;

        Program(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Program operator +(Program c1, Program c2)
        {
            return new Program(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }


        public override string ToString()
        {
            return string.Format("{0}+{1}i", real, imaginary);
        }

        static void Main(string[] args)
        {
            Program c1 = new Program(4, 3);
            Program c2 = new Program(7, 9);
            Program sum = c1 + c2;
            Console.WriteLine("The sum of the two complex numbers is: {0}", sum);
            Console.ReadLine();

        }
    }
}
