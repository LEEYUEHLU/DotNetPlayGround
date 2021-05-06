using System;
using System.Collections.Generic;

namespace Solution
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        Dictionary<char,int> lastUpdatedIndex = new Dictionary<char, int>();

        internal int LenghOfLongestSubstring(string examinedString)
        {
            int tailOfCharacter = -1; 
            int result = 0;
            for (int i=0 ; i<examinedString.Length; i++)
            {
                var character = examinedString[i];
                tailOfCharacter = Math.Max(GetLastUpdateIndexOfCharacter(character), tailOfCharacter);
                result = Math.Max(result, i - tailOfCharacter);
                lastUpdatedIndex[character] = i;
                Console.WriteLine($"character:{character}, cuurentIndex:{i}, end:{tailOfCharacter} result:{result}");
            }
            return result;
        }

        private int GetLastUpdateIndexOfCharacter(char character)
        {
            int lastUpdateIndex = -1;
            if (lastUpdatedIndex.ContainsKey(character))
            {
                lastUpdateIndex = lastUpdatedIndex[character];
            }
            return lastUpdateIndex;
        }
    }
}