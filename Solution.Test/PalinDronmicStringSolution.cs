using System;

namespace Solution
{
    public class PalinDronmicStringSolution
    {
        public string Resolve(string givenString, char caharacter){
            int index = givenString.IndexOf(caharacter);
            int low = index;
            int high = index;
            if(index + 1 < givenString.Length && givenString[index + 1] == givenString[index]){
                high = index + 1;
            }
            while(
                low > 0 &&
                high < givenString.Length &&
                givenString[low] == givenString[high]
             ){
                low = low - 1 > 0 ? low - 1 : 0;
                high = high + 1 >= givenString.Length ? high : high + 1; 
            }
            if(givenString[low] != givenString[high]){
                low += 1;
                high -= 1;
            }
            if(index == low && index == high){
                return string.Empty;
            }
            return givenString.Substring(low,high - low + 1);
        } 

        public string Resolve(string givenString)
        {
            int indexOfMaximumPalinDronicCenterCharacter = 0;
            int maximumPalinDronicNumbers = 0;
            for (int i = 0; i < givenString.Length; i++)
            {
                var palindronicString = Resolve(givenString,givenString[i]);
                if(maximumPalinDronicNumbers < palindronicString.Length){
                    indexOfMaximumPalinDronicCenterCharacter = i;
                    maximumPalinDronicNumbers = palindronicString.Length;
                }
            }
            return Resolve(givenString, givenString[indexOfMaximumPalinDronicCenterCharacter]);
        }
    }
}