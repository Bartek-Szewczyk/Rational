using System;
using System.Security.Cryptography.X509Certificates;

namespace RationalLib
{
    //immutable 
    public readonly struct Rational32
    {
        private readonly int numerator;
        public int Numerator => numerator;

        private readonly int denominator;

        public int Denominator => denominator;




        #region stale
        public static readonly Rational32 ZERO = new Rational32(0, 1);
        public static readonly Rational32 One;
        public static readonly Rational32 Half;

        #endregion



        #region ctor's
        static Rational32()
        {
            ZERO =new Rational32(0,1);
            One = new Rational32(1, 1);
            Half = new Rational32(1, 2);
        }


        public Rational32(int numerator = 1, int denominator = 1)
        {
            this.numerator = numerator;
            this.denominator = denominator;

        }

        #endregion

        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}
