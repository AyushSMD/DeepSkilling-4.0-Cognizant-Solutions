using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator = null;
        }

        [Test]
        public void Addition_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            double result = calculator.Addition(5.5, 4.5);
            Assert.AreEqual(10.0, result);
        }

        [Test]
        public void Division_ByZero_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }
    }
}
