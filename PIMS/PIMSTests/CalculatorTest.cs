using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PIMS.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator sut;
        [TestFixtureSetUp]
        public void TestSetup()
        {
            sut = new Calculator();
        }

        [Test]
        public void ShouldAddNumbers()
        {
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [TestFixtureTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}
