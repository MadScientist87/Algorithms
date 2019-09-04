using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.BitManipulation;

namespace AlgorithmTests
{
    [TestClass]
    public class BitManipulationTests
    {

        [TestMethod]
        public void TestLogicalShiftLeft()
        {
            int x = 4;
            x = x << 1;
            var binary = x.ToBinaryString();

            Assert.AreEqual(x, 8);
        }


        [TestMethod]
        public void TestLogicalShiftRight()
        {
            int x = 4;
            x = x >> 1;
            var binary = x.ToBinaryString();

            Assert.AreEqual(x, 2);
        }


        [TestMethod]

        /*
         * "&" Binary AND Operator copies a bit to the result if it exists in both operands.    
         * 00000101=5
         * 00000111=7
         * c= a&b is 5 because both binary numbers have 1s in the 1 and 4 place 
        */
        public void TestAND()
        {
            int a = 5;
            int b = 7;
            int c;
            c= a & b;
            Assert.AreEqual(c, 5);
        }

        [TestMethod]

        /*
         * "|" Binary OR Operator copies a bit if it exists in either operand.    
         * 00001000=8
         * 00000101=5
         * c= a|b is 13 because we copied the ones that exist in either operand
         * 
        */
        public void TestOR()
        {
            int a = 8;
            int b = 5;
            int c;
            c = a | b;
            Assert.AreEqual(c, 13);
        }

        [TestMethod]

        /*
         * "^" Binary XOR Operator copies the bit if it is set in one operand but not both.    
         * 00110001=49
         * 00010000=16
         * 
         * 
        */
        public void TestXOR()
        {
            int a = 49;
            int b = 16;
            int c;
            c = a ^ b;
            a.ToBinaryString();
            b.ToBinaryString();
            Assert.AreEqual(c, 33);
        }

        [TestMethod]

        /*
         * "~" Binary Ones Complement Operator is unary and has the effect of 'flipping' bits.   
         * 
        */
        public void TestOnesComplement()
        {
            int a = 4;
            int b ;

            b = ~a;
            Assert.AreEqual(b, -5);
        }

        [TestMethod]

        /*
         * "~" Binary Ones Complement Operator is unary and has the effect of 'flipping' bits.   
         *  In order to get the negation of 4 correct i use the ~ operator to get the inverse (ones complement) then add 1 to get the exact negative
         * https://www.youtube.com/watch?v=4qH4unVtJkE&vl=en        
        */
        public void TestTwosComplement()
        {
            int a = 4;
            int b;

            b = ~a +1;
            Assert.AreEqual(b, -4);
        }
    }
}
