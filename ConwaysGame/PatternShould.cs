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
        public void ShouldReturnBlockPattern(string input)
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.BlockPatternShouldReturn(input);
            string actualPattern = "0000\n0XX0\n0XX0\n0000";
            Assert.AreEqual(actualPattern, returnedPattern);
        }

        [TestCase("000\n0X0\n000")]
        public void ShouldReturnDead (string input)
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.UnderPopulationDeathShouldReturn(input);
            string actualPattern = "dead";
            Assert.AreEqual(actualPattern, returnedPattern);
        }

        [TestCase("000\n0X0\n000")]
        public void ShouldReturnUnderpopulatedTransformedString(string input)
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.UnderPopulationTransformedString(input);
            string actualPattern = "000\n000\n000";
            Assert.AreEqual(actualPattern, returnedPattern);
        }
    }
}
