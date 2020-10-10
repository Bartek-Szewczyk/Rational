using System;
using RationalLib;

namespace RationalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational32 u = new Rational32(1, 2);

            var w = new Rational32();
            var v=new Rational32(5);

            var x = Rational32.ZERO;

            Console.WriteLine(u);
            Console.WriteLine(w);
            Console.WriteLine(v);
            Console.WriteLine(x);

        }
    }
}
