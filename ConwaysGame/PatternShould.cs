using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConwaysGame
{
    [TestFixture]
    public class PatternShould
    {
        [TestCase("0000\n" + //input
                  "0XX0\n" +
                  "0XX0\n" +
                  "0000",

                  "0000\n" + // output
                  "0XX0\n" +
                  "0XX0\n" +
                  "0000")]
        public void ShouldReturnBlockPattern(string input, string expected)
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.BlockPatternShouldReturn(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase("000\n" +
                  "0X0\n" +
                  "000",

                  "000\n" +
                  "000\n" +
                  "000")]
        public void ShouldReturnUnderpopulatedDeadTransformedString(string input, string expected) 
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase("0X00\n" +
                  "0X00\n" +
                  "0X00\n" +
                  "0000",

                  "0000\n" +
                  "XXX0\n" +
                  "0000\n" +
                  "0000")]
        public void ShouldReturnNextGenTransformedString(string input, string expected) //2nd rule
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase(new [] {"0X00",
                          "0X00",
                          "0X00",
                          "0000" },
            
                            1,
                            1)]
        public void ShouldCheckLiveNeighbours(string[] array, int row, int column)
        {
            Pattern getPattern = new Pattern();
            int returnedPattern = getPattern.CheckNeighboursWithMinMax(array, row, column);
            Assert.AreEqual(2, returnedPattern);
        }

        [TestCase("00000\n" +
                  "00X00\n" +
                  "00X00\n" +
                  "00X00\n" +
                  "00000",

                  "00000\n" +
                  "00000\n" +
                  "0XXX0\n" +
                  "00000\n" +
                  "00000")]

        public void ShouldReturnBlinkerString(string input, string expected)
        {
            Pattern getPattern = new Pattern();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }
    }
}
