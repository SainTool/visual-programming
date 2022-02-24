using System;
using Numb;
using Except;

namespace visual_programming
{
    class Program{
        static void Main(string[] args) {
            ushort t1 = ((ushort)331);
            RomanNumber b1 = new RomanNumber(t1);
            ushort t2 = ((ushort)152);
            RomanNumber b2 = new RomanNumber(t2);
            Console.WriteLine( t1 + " = " + b1.ToString());
            Console.WriteLine( t2 + " = " + b2.ToString());
            Console.WriteLine("Arabian \t\t|\tRoman");
            Console.WriteLine( t1 + " + " + t2 + " = " + ((int)t1 + (int)t2) + " \t|\t" + b1.ToString() + " + " + b2.ToString() + " = " + RomanNumber.Add(b1, b2));
            Console.WriteLine( t1 + " - " + t2 + " = " + ((int)t1 - (int)t2) + " \t|\t" + b1.ToString() + " - " + b2.ToString() + " = " + RomanNumber.Sub(b1, b2));
            t1 = ((ushort)25);
            b1 = new RomanNumber(t1);
            t2 = ((ushort)5);
            b2 = new RomanNumber(t2);
            Console.WriteLine( t1 + " * " + t2 + " = " + ((int)t1 * (int)t2) + " \t\t|\t" + b1.ToString() + " * " + b2.ToString() + " = " + RomanNumber.Mul(b1, b2));
            Console.WriteLine( t1 + " / " + t2 + " = " + ((int)t1 / (int)t2) + " \t\t|\t" + b1.ToString() + " / " + b2.ToString() + " = " + RomanNumber.Div(b1, b2));
            short[] mass = new short[] { 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            RomanNumber[] massRN = new RomanNumber[mass.Length];
            Console.WriteLine("Mass");
            for (int i = 0; i < massRN.Length; i++)
            {
                massRN[i] = new RomanNumber((ushort)mass[i]);
                Console.Write(massRN[i].ToString() + " ");
            }
            Console.WriteLine("\nSorted mass");
            Array.Sort(massRN);
            for (int i = 0; i < massRN.Length; i++)
            {
                Console.Write(massRN[i].ToString() + " ");
            }
        }
    }
}
