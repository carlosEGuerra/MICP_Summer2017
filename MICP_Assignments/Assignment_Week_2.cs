using System;
using System.Linq;
using System.Text;

namespace MICP_Assignments
{
    public class Assignment_Week_2
    {
        public static string LongestSubstring(String userInput)
        {
            if (String.IsNullOrEmpty(userInput))
            {
                throw new ArgumentException();
            }
            string longestString = "";

            StringBuilder longestSubstringSoFar = new StringBuilder();

            foreach(char c in userInput)
            {
                //checks to see if the character is contained in the substring
                bool isContained = longestSubstringSoFar.ToString().Contains(c);

                if (!isContained)
                {
                    longestSubstringSoFar.Append(c);
                }
                else if (isContained)
                {
                    int indexOfChar = longestSubstringSoFar.ToString().IndexOf(c);
                    StringBuilder temp = new StringBuilder();

                    for (int i = indexOfChar + 1; i<longestSubstringSoFar.ToString().Length; i++)
                    {
                        temp.Append(longestSubstringSoFar.ToString()[i]);
                    }
                    longestSubstringSoFar = temp;
                    longestSubstringSoFar.Append(c);
                }

                if (longestSubstringSoFar.ToString().Length > longestString.Length)
                {
                    longestString = longestSubstringSoFar.ToString();
                }
            }
            return longestString;
        }
    }
}
