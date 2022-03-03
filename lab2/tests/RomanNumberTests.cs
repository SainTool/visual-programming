using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numb;
using System;
using System.Collections.Generic;
using System.Text;

namespace Numb.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void CheckDataOutputTrue()
        {
            ushort t1 = ((ushort)10);
            RomanNumber b1 = new RomanNumber(t1);
            Assert.AreEqual("X", b1.ToString());
        }
        [TestMethod()]
        public void CheckDataOutputFalse()
        {
            ushort t1 = ((ushort)10);
            RomanNumber b1 = new RomanNumber(t1);
            Assert.AreNotEqual("XI", b1.ToString());
        }
        [TestMethod()]
        public void CheckSummTrue()
        {
            ushort t1 = ((ushort)1);
            RomanNumber b1 = new RomanNumber(t1);
            Assert.AreEqual("II", b1+b1.ToString());
        }
        [TestMethod()]
        public void CheckSummFalse()
        {
            ushort t1 = ((ushort)1);
            RomanNumber b1 = new RomanNumber(t1);
            Assert.AreNotEqual("III", (b1 + b1).ToString());
        }
        [TestMethod()]
        public void CheckDivTrue()
        {
            ushort t1 = ((ushort)10), t2 = ((ushort)5);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2);
            Assert.AreEqual("V", (b1-b2).ToString());
        }
        [TestMethod()]
        public void CheckDivFalse()
        {
            ushort t1 = ((ushort)10), t2 = ((ushort)5);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2);
            Assert.AreNotEqual("VI", (b1 - b2).ToString());
        }

    }
}