using System;
using System.Collections;
using System.Collections.Generic;

namespace MICP_Assignments
{
    public class Assignment_Week_3
    {
        public static int[][] uniqueTripletCombinations(int[] userInput)
        {
            //checks to ensure that there IS input into the array
            if (userInput == null || userInput.Length <= 0)
                return null;

            //if there isn't enough input
            if (userInput.Length < 3)
                throw new ArgumentException();

            //used to contain the pending results
            List<int[]> results = new List<int[]>();

            //organizes the user input
            Array.Sort(userInput);

            //O(n^3) Complexity, this REALLY does need to be improved
            for(int firstIndex = 0; firstIndex < userInput.Length - 3; firstIndex++)
            {
               for(int secondIndex = firstIndex + 1; secondIndex < userInput.Length - 2; secondIndex++)
                {
                    for(int thirdIndex = secondIndex + 1; thirdIndex < userInput.Length - 1; thirdIndex++)
                    {
                        if((userInput[firstIndex] + userInput[secondIndex] + userInput[thirdIndex]) == 0)
                        {
                            int[] temp = new int[3];
                            temp[0] = userInput[firstIndex];
                            temp[1] = userInput[secondIndex];
                            temp[2] = userInput[thirdIndex];
                            if(!results.Contains(temp))
                                results.Add(new int[] { userInput[firstIndex], userInput[secondIndex], userInput[thirdIndex]});

                            
                        }
                    }
                }
            }

            return results.ToArray();
        }
    }
}
