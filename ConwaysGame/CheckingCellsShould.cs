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
    public class CheckingCellsShould
    {
        [TestCase("****\n" + //input
                  "*11*\n" +
                  "*11*\n" +
                  "****",

                  "****\n" + // output
                  "*11*\n" +
                  "*11*\n" +
                  "****")]
        public void ShouldReturnBlockPattern(string input, string expected)
        {
            CheckingCells getPattern = new CheckingCells();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase("***\n" +
                  "*1*\n" +
                  "***",

                  "***\n" +
                  "***\n" +
                  "***")]
        public void ShouldReturnUnderpopulatedDeadTransformedString(string input, string expected) 
        {
            CheckingCells getPattern = new CheckingCells();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase("*1**\n" +
                  "*1**\n" +
                  "*1**\n" +
                  "****",

                  "****\n" +
                  "111*\n" +
                  "****\n" +
                  "****")]
        public void ShouldReturnNextGenTransformedString(string input, string expected) //2nd rule
        {
            CheckingCells getPattern = new CheckingCells();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase(new [] {"*1**",
                          "*1**",
                          "*1**",
                          "****" },
            
                            1,
                            1)]
        public void ShouldCheckLiveNeighbours(string[] array, int row, int column)
        {
            CheckingCells getPattern = new CheckingCells();
            int returnedPattern = getPattern.CheckNeighbours(array, row, column);
            Assert.AreEqual(2, returnedPattern);
        }

        [TestCase("*****\n" +
                  "**1**\n" +
                  "**1**\n" +
                  "**1**\n" +
                  "*****",

                  "*****\n" +
                  "*****\n" +
                  "*111*\n" +
                  "*****\n" +
                  "*****")]

        public void ShouldReturnBlinkerString(string input, string expected)
        {
            CheckingCells getPattern = new CheckingCells();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

        [TestCase("******\n" +
                  "***1**\n" +
                  "*1**1*\n" +
                  "*1**1*\n" +
                  "**1***\n"+
                  "******",

                  "******\n" +
                  "******\n" +
                  "**111*\n" +
                  "*111**\n" +
                  "******\n"+
                  "******")]

        public void ShouldReturnToadString(string input, string expected)
        {
            CheckingCells getPattern = new CheckingCells();
            string returnedPattern = getPattern.TransformedCellString(input);
            Assert.AreEqual(expected, returnedPattern);
        }

    }
}
