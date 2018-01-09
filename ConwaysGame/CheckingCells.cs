using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework.Api;


namespace ConwaysGame
{
    public class CheckingCells
    {
        
        public string TransformedCellString(string input)
        {
            var array = input.Split('\n');
            var result = "";

            for (int row = 0; row < array.Length; row++) // rows
            {
                for (int column = 0; column < array[0].Length; column++) // columns
                {
                    result = GetNextState(array, row, column, result);
                }
                result += '\n';
            }
           
            return result.TrimEnd('\n');
        }

        private string GetNextState(string[] array, int row, int column, string result)
        {
            if (array[row][column] == '*')
            {
                result = DeadCellTransformation(array, row, column, result);
            }

            if (array[row][column] == '1')
            {
                result = AliveCellTransformation(array, row, column, result);
            }
            return result;
        }

        private string AliveCellTransformation(string[] array, int row, int column, string result)
        {
            var numberOfLiveNeighbours = CheckNeighbours(array, row, column);

            if (numberOfLiveNeighbours < 2 || numberOfLiveNeighbours > 3)
            {
                result += '*';
            }
            else if (numberOfLiveNeighbours == 2 || numberOfLiveNeighbours == 3)
            {
                result += '1';
            }
            return result;
        }

        private string DeadCellTransformation(string[] array, int row, int column, string result)
        {
            var numberOfLiveNeighbours = CheckNeighbours(array, row, column);

            if (numberOfLiveNeighbours == 3)
            {
                result += '1';
            }
            else
                result += '*';
            return result;
        }

        public int CheckNeighbours(string[] array, int row, int column)
        {
            //var
            var totalColumns = array[0].Length -1;
            var totalRows = array.Length - 1;
            var count = 0;
            
            var minRows = Math.Max(0, row - 1);
            var maxRows = Math.Min(row + 1, totalRows);
            var minColumns = Math.Max(0, column - 1);
            var maxColumns = Math.Min(column + 1, totalColumns);

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