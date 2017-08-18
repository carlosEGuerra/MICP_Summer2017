using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MICP_Assignments;
using System.Collections.Generic;

namespace UnitTestsForAssignment3
{
    [TestClass]
    public class UnitTest1
    {
        private int[] inputArrayForTest = new int[6];
        private int[][] testArray1 = new int[2][];

        [TestInitialize]
        public void arrayInitializationForTesting()
        {
            //initializes the input array
            inputArrayForTest[0] = -1;
            inputArrayForTest[1] = 0;
            inputArrayForTest[2] = 1;
            inputArrayForTest[3] = 2;
            inputArrayForTest[4] = -1;
            inputArrayForTest[5] = -4;

            //initalizes the test results array
            int[] temp1 = new int[3];
            temp1[0] = -1;
            temp1[1] = 0;
            temp1[2] = 1;

            int[] temp2 = new int[3];
            temp2[0] = -1;
            temp2[1] = -1;
            temp2[2] = 2;

            testArray1[0] = temp1;
            testArray1[1] = temp2;

        }
        [TestMethod]
        public void TestWith6intArray_2OutputArrays()
        {
            Assert.AreEqual(testArray1, Assignment_Week_3.uniqueTripletCombinations(inputArrayForTest));

        }
    }
}
