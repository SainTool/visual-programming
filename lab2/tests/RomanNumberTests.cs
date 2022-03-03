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
        public void CheckAddTrue()
        {
            ushort t1 = ((ushort)1);
            RomanNumber b1 = new RomanNumber(t1);
            Assert.AreEqual("II", b1+b1.ToString());
        }
        [TestMethod()]
        public void CheckAddFalse()
        {
            ushort t1 = ((ushort)1);
            RomanNumber b1 = new RomanNumber(t1);
            Assert.AreNotEqual("III", (b1 + b1).ToString());
        }
        [TestMethod()]
        public void CheckSubTrue()
        {
            ushort t1 = ((ushort)10), t2 = ((ushort)5);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2);
            Assert.AreEqual("V", (b1-b2).ToString());
        }
        [TestMethod()]
        public void CheckSubFalse()
        {
            ushort t1 = ((ushort)10), t2 = ((ushort)5);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2);
            Assert.AreNotEqual("VI", (b1 - b2).ToString());
        }
        [TestMethod()]
        public void CheckMulTrue()
        {
            ushort t1 = ((ushort)35), t2 = ((ushort)5), t3 = (ushort)(t1*t2);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2), b3 = new RomanNumber(t3);
            Assert.AreEqual(b3.ToString(), (b1 * b2).ToString());
        }
        [TestMethod()]
        public void CheckMulFalse()
        {
            ushort t1 = ((ushort)35), t2 = ((ushort)5), t3 = (ushort)(t1*t2);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2), b3 = new RomanNumber(t3);
            Assert.AreNotEqual(b3.ToString()+"I", (b1 * b2).ToString());
        }
        [TestMethod()]
        public void CheckDivTrue()
        {
            ushort t1 = ((ushort)35), t2 = ((ushort)5), t3 = (ushort)(t1 / t2);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2), b3 = new RomanNumber(t3);
            Assert.AreEqual(b3.ToString(), (b1 / b2).ToString());
        }
        [TestMethod()]
        public void CheckDivFalse()
        {
            ushort t1 = ((ushort)35), t2 = ((ushort)5), t3 = (ushort)(t1 / t2);
            RomanNumber b1 = new RomanNumber(t1), b2 = new RomanNumber(t2), b3 = new RomanNumber(t3);
            Assert.AreNotEqual(b3.ToString() + "I", (b1 / b2).ToString());
        }
        [TestMethod()]
        public void CheckArraySortTrue()
        {
            RomanNumber b1 = new RomanNumber(5), b2 = new RomanNumber(10), b3 = new RomanNumber(15), b4 = new RomanNumber(20);
            RomanNumber[] expected = { b1, b2, b3, b4 };
            RomanNumber[] startMass = { b4, b3, b2, b1 };
            Array.Sort(startMass);
            for(int i=0;i<4;i++)
                Assert.AreEqual(expected[i], startMass[i]);
        }
        [TestMethod()]
        public void CheckArraySortFalse()
        {
            RomanNumber b1 = new RomanNumber(5), b2 = new RomanNumber(10), b3 = new RomanNumber(15), b4 = new RomanNumber(20);
            RomanNumber[] expected = { b2, b3, b4, b1 };
            RomanNumber[] startMass = { b4, b3, b2, b1 };
            Array.Sort(startMass);
            for (int i = 0; i < 4; i++)
                Assert.AreNotEqual(expected[i], startMass[i]);
        }
        [TestMethod()]
        public void CheckCloneTrue()
        {
            RomanNumber b1 = new RomanNumber (5), b2 = (RomanNumber)b1.Clone();
            Assert.AreNotEqual(b1, b2);
        }

    }
}