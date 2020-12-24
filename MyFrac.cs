using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Laba5_Task1
{
    class MyFrac : IMyNumber<MyFrac>
    {
        private BigInteger denom;
        private BigInteger nom;
        public MyFrac(BigInteger nom, BigInteger denom)
        {
            if (denom.Equals(BigInteger.Zero))
                throw new DivideByZeroException($"Division by zero, numerator = {nom} ,denominator = {denom}");
            Simplify(nom, denom);
            this.nom = nom;
            this.denom = denom;
        }

        public MyFrac Add(MyFrac that) => new MyFrac(this.nom * that.denom + that.nom * this.denom, this.denom * that.denom);

        public MyFrac Subtract(MyFrac that) => new MyFrac((nom * that.denom) - (that.nom * denom), denom * that.denom);

        public MyFrac Multiply(MyFrac that) => new MyFrac(nom * that.nom, denom * that.denom);

        public MyFrac Divide(MyFrac that) => new MyFrac(nom * that.denom, denom * that.nom);

        public override string ToString() => $"{nom}/{denom}";

        private void Simplify(BigInteger nom, BigInteger denom)
        {
            BigInteger gcd = BigInteger.GreatestCommonDivisor(nom, denom);
            nom /= gcd;
            denom /= gcd;
        }
    }
}
