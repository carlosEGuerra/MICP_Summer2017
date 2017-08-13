using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MICP_Assignments
{
    public class Assignment_Week_4
    {
        /*
         * This method takes in a dictionary array and a user input and breaks up the
         * user input into words so that it can check to see if the words are contained
         * in the dictionary. 
         * 
         * If the word is in the dictionary then the method would coninue on going
         * through the input until the end of the string. 
         * 
         * If the word is not found in the dictionary the method would continue on until 
         * it exits the foreach loop and when checking the size would return whether or
         * not a word was in the dictionary as the length of the string would be > 0.
         * 
         * The complexity of this method is O(n^2) and could be done more efficiently.
        */
        public static bool StringSegmentation(string[] dictionary, string userInput)
        {
            if(userInput == null)
            {
                throw new ArgumentException();
            }

            if(userInput.Length == 0 || dictionary.Length == 0)
            {
                return false;
            }

            //builds the word possibilities
            StringBuilder wordPossibility = new StringBuilder();

            //O(n^2) complexity, O(n) for the foreach and O(n) for the embeded dictionary.contains
            foreach(char c in userInput)
            {
                //creates the word
                wordPossibility.Append(char.ToLower(c));
                //checks to see if the word is in the dictionary
                if (dictionary.Contains(wordPossibility.ToString()))
                {
                    wordPossibility = new StringBuilder();
                }
            }
            //checks to see if any word isn't contained in the dictionary
            if(wordPossibility.Length != 0)
            {
                return false;
            }

            //if the wordPossibility is zero its because all the words are contained in the dictionary
            return true;
        }
    }
}
