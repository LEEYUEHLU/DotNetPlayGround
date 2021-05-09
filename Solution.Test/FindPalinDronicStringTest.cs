using NUnit.Framework;
using Solution;

[TestFixture]
public class FindPanliDronicStringTest{

        [Test]
        public void FindPanlinDronicString_StartedFromA_ReturnEmpty(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual(string.Empty,solution.Resolve("aba",'a'));
        }

        [Test]
        public void FindPalinDronicString_StartedFromBwhichIsCenter_ReturnSingleCenteredPanlinDronicString(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("aba",solution.Resolve("aba",'b'));
        }

        [Test]
        public void FindPanlinDronicString_ExpandedAroudCenter(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("cabac",solution.Resolve("cabac",'b'));
        }

        [Test]
        public void FindPalinDronicString_OnlyExpandOnce(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("aba",solution.Resolve("caban",'b'));
        }

        [Test]
        public void FindPalinDronicString_WithDoubleCenter(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("abba",solution.Resolve("abba",'b'));
        }


        [Test]
        public void FindPalinDronicString_WithDoubleCenterAndExpandOnlyOnce(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("bb",solution.Resolve("abbc",'b'));
        }

        [Test]
        public void FindPalinDronicString_tracecars_ReturnRACECAR(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("racecar",solution.Resolve("tracecars"));
        }

        [Test]
        public void FindPalinDronicString_traceecars_ReturnRACEECAR(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("raceecar",solution.Resolve("traceecars"));
        }

        [Test]
        public void FindPalinDronicString_abcde_ReturnEmpty(){
            PalinDronmicStringSolution solution = new PalinDronmicStringSolution();
            Assert.AreEqual("",solution.Resolve("abcde"));
        }
}