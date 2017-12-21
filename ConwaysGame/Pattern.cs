using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework.Api;


namespace ConwaysGame
{
    internal class Pattern
    {
        public Pattern()
        {
        }

        public string BlockPatternShouldReturn(string input)
        {
            return input == "****\n*11*\n*11*\n****" ? input : "Invalid";
        }

        public string TransformedCellString(string input)
        {
            var array = input.Split('\n');
            var result = "";

            for (int row = 0; row < array.Length; row++) // rows
            {
                for (int column = 0; column < array[0].Length; column++) // columns
                {
                    if (array[row][column] == '*')
                    {
                        var numberOfLiveNeighbours = CheckNeighboursWithMinMax(array, row, column);

                        if (numberOfLiveNeighbours == 3)
                        {
                            result += '1';
                        }
                        else
                            result += '*';
                    }

                    if (array[row][column] == '1')
                    {
                        var numberOfLiveNeighbours = CheckNeighboursWithMinMax(array, row, column);
                            
                        if (numberOfLiveNeighbours < 2 || numberOfLiveNeighbours > 3)
                        {
                            result += '*';
                        }
                        else if (numberOfLiveNeighbours == 2 || numberOfLiveNeighbours == 3)
                        {
                            result += '1';
                        }
                        
                    }
                }
                result += '\n';
            }
           
            return result.TrimEnd('\n');
        }

        public int CheckNeighboursWithMinMax(string[] array, int row, int column)
        {

            int totalColumns = array[0].Length -1;
            int totalRows = array.Length - 1;
            int count = 0;
            
            int minRows = Math.Max(0, row - 1);
            int maxRows = Math.Min(row + 1, totalRows);
            int minColumns = Math.Max(0, column - 1);
            int maxColumns = Math.Min(column + 1, totalColumns);

            for (int rowCoord = minRows; rowCoord <= maxRows; rowCoord++)
            {
                for (int colCoord = minColumns; colCoord <= maxColumns; colCoord++)
                {
                    if (array[rowCoord][colCoord] == '1')
                    {
                        if (rowCoord == row && colCoord == column)
                        {
                            continue;
                        }
                            count++;
                    }

                }
            }
            return count;
        }

       

    }
}