using mynotes.Utils;
using NUnit.Framework;

namespace mynotes.Tests.Utils
{
    public class CalcTests
    {
        private Calc calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calc();
        }

        [Test]
        public void ShouldAddxy()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }
    }
}
