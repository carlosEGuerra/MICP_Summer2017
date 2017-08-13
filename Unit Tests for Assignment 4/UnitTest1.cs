using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MICP_Assignments;

namespace Unit_Tests_for_Assignment_4
{
    [TestClass]
    public class UnitTest1
    {
        string[] dictionary;

        [TestInitialize]
        public void testSetupForUnitTestOfExample()
        {
            //initialize the dictionary
            dictionary = new string[] { "pear", "salmon", "foot", "prints", "footprints", "leave", "you", "sun", "girl", "enjoy"};
        }

        [TestMethod]
        public void TestExampleFromTEBOWIT()
        {
            Assert.AreEqual(true, Assignment_Week_4.StringSegmentation(dictionary, "youenjoy"));
        }

        [TestMethod]
        public void testForFalseOutput()
        {
            Assert.AreEqual(false, Assignment_Week_4.StringSegmentation(dictionary, "salmonenjoyapples"));
        }

        [TestMethod]
        public void testForTrueOutput()
        {
            Assert.AreEqual(true, Assignment_Week_4.StringSegmentation(dictionary, "youleavefootprints"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void testForNullInput()
        {
            Assignment_Week_4.StringSegmentation(dictionary, null);
        }

        [TestMethod]
        public void testForEmptyDictionary()
        {
            dictionary = new string[10];
            Assert.AreEqual(false, Assignment_Week_4.StringSegmentation(dictionary, "youenjoy"));
        }

        [TestMethod]
        public void testForEmptyString()
        {
            Assert.AreEqual(false, Assignment_Week_4.StringSegmentation(dictionary, ""));
        }
    }
}
