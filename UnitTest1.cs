using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MICP_Assignments;
using System.Collections.Generic;

namespace UnitTestsForAssignment3
{
    [TestClass]
    public class UnitTest1
    {
        private int[] testArray = new int[10];

        [TestInitialize]
        public void arrayInitializationForTesting()
        {
            Random rand = new Random();
            for(int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = rand.Next() % 10;
            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(set);
            Console.ReadLine();
        }
    }
}
