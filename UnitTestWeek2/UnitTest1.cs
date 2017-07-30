using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MICP_Assignments;

namespace UnitTestWeek2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("hel", Assignment_Week_2.LongestSubstring("hello"));
        }

        [TestMethod]
        public void TestStringInput()
        {
            Assert.AreEqual("jksdbv", Assignment_Week_2.LongestSubstring("isdsvjjksdbv"));
        }

        [TestMethod]
        public void TestStringInput2()
        {
            Assert.AreEqual("abc", Assignment_Week_2.LongestSubstring("abcabcbb"));
        }

        [TestMethod]
        public void TestStringInput3()
        {
            Assert.AreEqual("b", Assignment_Week_2.LongestSubstring("bbbbbbbbbbbbbbbbbbbbbb"));
        }

        [TestMethod]
        public void TestStringInput4()
        {
            Assert.AreEqual("wke", Assignment_Week_2.LongestSubstring("pwwkew"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullTestMethod()
        {
            Assignment_Week_2.LongestSubstring("");
        }
    }
}
