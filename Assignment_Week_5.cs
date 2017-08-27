using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICP_Assignments
{
    public class Assignment_Week_5
    {
        /*
         * This function checks to see if the users LinkedList input is a
         * palindrome. This algorithm runs in O(n) time complexity and O(2n) 
         * space complexity as it has to save the reverse of itself.
         */
        public static bool isPalindrome(LinkedList<char> userInput)
        {
            if (userInput == null || userInput.Count == 0)
                throw new ArgumentException();

            //initializes the stack to be used
            Stack<char> charStack = new Stack<char>();

            /*
             * The next two foreach loops make this algorithm a complexity of O(n + m)
             * which becomes an O(n) complexity as popping and pushing onto stacks has
             * a complexity of O(1) and the only thing we have to traverse is the linked
             * list
             */

            //adds the character from the linked list to the stack
            foreach(char c in userInput)
            {
                charStack.Push(c);
            }

            foreach(char character in userInput)
            {
                //gets the character on the top of the stack
                char characterToBeCompared = charStack.Pop();

                //compares the character from the top of the stack to the character in the linked list
                if(characterToBeCompared == character)
                {
                    continue;
                }

                //if the comparison fails then it would return false
                return false;
            }
            //if it goes through the second foreach loop then the userInput is a palindrome
            return true;
        }
    }
}
