using Algorithms.Easy;
using Algorithms.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmTests
{
    [TestClass]
    public class UnitTestsMedium
    {
        [TestMethod]
        public void LadderLength()
        {
           var answer= LadderLengthClass.LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
            Assert.AreEqual(answer, 5);
        }
    }
}
