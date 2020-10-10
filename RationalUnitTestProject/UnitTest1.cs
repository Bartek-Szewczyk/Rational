using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using RationalLib;

namespace RationalUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1,2, 1,2)]
        [DataRow(-2,3,-2,3)]
        [DataRow(2, -3,-2,3)]
        [DataRow(-2,-2,-2,3)]
        [DataRow(2,4,1,2)]
        public void TKonstrukterDwuArgumentowy_Poprawnie(int l, int m, int ExpectedNumerator, int ExpectedDominator)
        {

            Rational32 u = new Rational32(l,m);
            Assert.AreEqual(ExpectedNumerator, u.Numerator);
            Assert.AreEqual(ExpectedDominator, u.Denominator);
        }
    }
}
