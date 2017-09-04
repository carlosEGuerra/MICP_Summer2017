using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MICP_Assignments;

namespace Unit_Test_for_Assignment_6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BinaryTree tree = new BinaryTree('p', new BinaryTree('a'), new BinaryTree('c'));
            BinaryTree tree_s = new BinaryTree('p', new BinaryTree('a'), new BinaryTree('c'));
            Assert.AreEqual(true, Assignment_Week_6.subtreeComparison(tree, tree_s));
        }
    }
}
