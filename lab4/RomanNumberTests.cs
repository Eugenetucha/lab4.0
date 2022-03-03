using NUnit.Framework;
#nullable enable
namespace lab4;
using System;

[TestFixture]
public class RomanNumberTests
{
     [Test]
        public void RomanNumberTest_ValidValue()
        {
            RomanNumber a = new RomanNumber(5);
            int div=String.Compare(a.ToString(), "V");
            Assert.AreEqual(0, div);
        }

        [Test]
        public void RomanNumberTest_NotValidValue()
        {
            Assert.Throws<RomanNumberException>(() => new RomanNumber(0));
            Assert.Throws<RomanNumberException>(() => new RomanNumber(4000));
        }

        [Test]
        public void RomanNumberTest_OperationAdd()
        {
            RomanNumber? a = new RomanNumber(1468);
            RomanNumber? b = new RomanNumber(673);
            RomanNumber? c = null;
            Assert.AreEqual(0,(b+b).CompareTo(new RomanNumber(1563+1563)));
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a + c;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = c + b;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a + b;
            });
        }

        [Test]
        public void RomanNumberTest_OperationSub()
        {
            RomanNumber? a = new RomanNumber(1468);
            RomanNumber? b = new RomanNumber(673);
            RomanNumber? c = null;
            Assert.AreEqual(0, (a - b).CompareTo(new RomanNumber(2498 - 1563)));
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a - c;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = c - b;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = b - a;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = b - b;
            });
        }

        [Test]
        public void RomanNumberTest_OperationMul()
        {
            RomanNumber? a = new RomanNumber(53);
            RomanNumber? b = new RomanNumber(14);
            RomanNumber? c = null;
            Assert.AreEqual(0, (a * b).CompareTo(new RomanNumber(73 * 28)));
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a * c;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = c * b;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a * a;
            });
        }

        [Test]
        public void RomanNumberTest_OperationDiv()
        {
            ushort k = 3;
            RomanNumber? a = new RomanNumber(53);
            RomanNumber? b = new RomanNumber(14);
            RomanNumber? c = null;
            RomanNumber? d = new RomanNumber((ushort)(28*k));
            Assert.AreEqual(0, (d / b).CompareTo(new RomanNumber(k)));
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a / c;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = c / b;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a / b;
            });
            Assert.Throws<RomanNumberException>(() =>
            {
                var romanNumber = a / d;
            });
        }

        [Test]
        public void CloneTest()
        {
            RomanNumber a = new RomanNumber(20);
            RomanNumber b = (RomanNumber)a.Clone();
            Assert.AreNotEqual(a, b);
            Assert.AreEqual(0,a.CompareTo(b));
        }
        
    
}