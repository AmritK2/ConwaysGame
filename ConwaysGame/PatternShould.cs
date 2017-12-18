using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConwaysGame
{
    [TestFixture]
    public class PatternShould
    {
        [TestCase("0000\n0XX0\n0XX0\n0000")]
        public void TestGame(string input)
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.BlockPatternShouldReturn(input);
            string actualPattern = "0000\n0XX0\n0XX0\n0000";
            Assert.AreEqual(actualPattern, returnedPattern);
        }

    }
}
