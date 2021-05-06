using NUnit.Framework;

namespace Solution{
    
    [TestFixture]
    public class LongestSubstringWithoutRepeatingTests{
   
        [Test]
        public void GivenString_abrkaabcdefghijjxxx_Return10(){
            LongestSubstringWithoutRepeatingCharacters solution = new LongestSubstringWithoutRepeatingCharacters();
            Assert.That(solution.LenghOfLongestSubstring("abrkaabcdefghijjxxx"),Is.EqualTo(10));
        }
        
        [Test]
        public void GiveStringWitoutRepeatingWord_Return4(){
            LongestSubstringWithoutRepeatingCharacters solution = new LongestSubstringWithoutRepeatingCharacters();
            Assert.That(solution.LenghOfLongestSubstring("abcd"),Is.EqualTo(4));
        }
    }    
}