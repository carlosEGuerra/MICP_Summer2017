using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MICP_Assignments;
using System.Collections.Generic;

namespace Unit_Test_for_Assignment_5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindrome_UserInputNursesRun_ReturnFalse()
        {
            LinkedList<char> userInput = new LinkedList<char>();
            userInput.AddLast('N');
            userInput.AddLast('u');
            userInput.AddLast('r');
            userInput.AddLast('s');
            userInput.AddLast('e');
            userInput.AddLast('s');
            userInput.AddLast(' ');
            userInput.AddLast('R');
            userInput.AddLast('u');
            userInput.AddLast('n');

            Assert.AreEqual(false, Assignment_Week_5.isPalindrome(userInput));
        }

        [TestMethod]
        public void IsPalindrome_UserInputLOL_ReturnTrue()
        {
            LinkedList<char> userInput = new LinkedList<char>();
            userInput.AddLast('L');
            userInput.AddLast('O');
            userInput.AddLast('L');

            Assert.AreEqual(true, Assignment_Week_5.isPalindrome(userInput));
        }

        [TestMethod]
        public void IsPalindrome_UserInputHEHEHEHEHE_ReturnFalse()
        {
            LinkedList<char> userInput = new LinkedList<char>();
            userInput.AddLast('H');
            userInput.AddLast('E');
            userInput.AddLast('H');
            userInput.AddLast('E');
            userInput.AddLast('H');
            userInput.AddLast('E');
            userInput.AddLast('H');
            userInput.AddLast('E');
            userInput.AddLast('H');
            userInput.AddLast('E');

            Assert.AreEqual(false, Assignment_Week_5.isPalindrome(userInput));
        }

        [TestMethod]
        public void IsPalindrome_UserInputSeheTeHeS_ReturnTrue()
        {
            LinkedList<char> userInput = new LinkedList<char>();
            userInput.AddLast('S');
            userInput.AddLast('e');
            userInput.AddLast('h');
            userInput.AddLast('e');
            userInput.AddLast('t');
            userInput.AddLast('e');
            userInput.AddLast('h');
            userInput.AddLast('e');
            userInput.AddLast('S');

            Assert.AreEqual(true, Assignment_Week_5.isPalindrome(userInput));
        }

        [TestMethod]
        public void IsPalindrome_UserInput10101_ReturnTrue()
        {
            LinkedList<char> userInput = new LinkedList<char>();
            userInput.AddLast('1');
            userInput.AddLast('0');
            userInput.AddLast('1');
            userInput.AddLast('0');
            userInput.AddLast('1');

            Assert.AreEqual(true, Assignment_Week_5.isPalindrome(userInput));
        }

        [TestMethod]
        public void IsPalindrome_UserInput10101017_ReturnFalse()
        {
            LinkedList<char> userInput = new LinkedList<char>();
            userInput.AddLast('1');
            userInput.AddLast('0');
            userInput.AddLast('1');
            userInput.AddLast('0');
            userInput.AddLast('1');
            userInput.AddLast('0');
            userInput.AddLast('1');
            userInput.AddLast('7');

            Assert.AreEqual(false, Assignment_Week_5.isPalindrome(userInput));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsPalindrome_UserInputNull_ThrowsException()
        {
            LinkedList<char> userInput = null;

            Assignment_Week_5.isPalindrome(userInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsPalindrome_UserInputEmpty_ThrowsException()
        {
            LinkedList<char> userInput = new LinkedList<char>();

            Assignment_Week_5.isPalindrome(userInput);
        }
    }
}
