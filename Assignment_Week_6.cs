using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICP_Assignments
{
    /*
     * A Binary Tree Constructor with functionality for generic object data as 
     * well as one for 
     */
    public class BinaryTree
    {
        public Object data;
        public BinaryTree treeNodeLeft;
        public BinaryTree treeNodeRight;

        public BinaryTree(Object data)
        {
            this.data = data;
        }

        public BinaryTree(Object data, BinaryTree left, BinaryTree right)
        {
            this.data = data;
            this.treeNodeLeft = left;
            this.treeNodeRight = right;
        }
    }

    public class Assignment_Week_6
    {
        public static bool subtreeComparison(BinaryTree s, BinaryTree t)
        {
            if (t.Equals(null))
                return true;

            if (s.Equals(null))
                return false;

            if (areEqual(s, t))
                return true;

            return subtreeComparison(s, t.treeNodeLeft) || subtreeComparison(s, t.treeNodeRight);
        }

        private static bool areEqual(BinaryTree subtree, BinaryTree tree)
        {
            if (subtree.data.Equals(null) && tree.data.Equals(null))
                return true;

            if (subtree.data.Equals(null) || tree.data.Equals(null))
                return false;

            return subtree.data.Equals(tree.data) && areEqual(subtree.treeNodeLeft, tree.treeNodeLeft) && areEqual(subtree.treeNodeRight, tree.treeNodeRight);
        }
    }
}
