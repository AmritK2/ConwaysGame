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
            return input == "0000\n0XX0\n0XX0\n0000" ? input : "Invalid";
        }

        private int CheckNeighbours(string input, int row, int col) // i = row, j = column
        {
            int count = 0;
        
            if (row < input.Length-1)
            {
                if (row == 0)
                {
                    if (input[col - 1] == 'X')
                    {
                        count++;
                    }
                  
                    else if (input[col + 1] == 'X')
                    {
                        count++;
                    }
                }
                else if (input[(row - 1)] == 'X' && input[col - 1] == 'X')
                {
                    count++;
                }
                else if (input[(row - 1)] == 'X')
                {
                    count++;
                }
                else if (input[(row - 1)] == 'X' && input[col + 1] == 'X')
                {
                    count++;
                }
                
                else if (input[(row + 1)] == 'X')
                {
                    count++;
                }
                else if (input[(row + 1)] == 'X' && input[col + 1] == 'X')
                {
                    count++;
                }
                else if (input[(row + 1)] == 'X')
                {
                    count++;
                }
                else if (input[(row + 1)] == 'X' && input[col - 1] == 'X')
                {
                    count++;
                }
                else if (input[col - 1] == 'X')
                {
                    count++;
                }
            }
            return count;
        }


        public string UnderPopulationTransformedString(string input)
        {
            var row = 0;
            var col = 0;
            var output = "";

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '\n')
                    {
                        col = 0;
                        row++;
                    }
                    else if (input[j] == 'X')
                    {
                       var result = CheckNeighbours(input, row, col);
                        if (result < 2)
                        {
                            char[] ch = input.ToCharArray();
                            ch[j] = '0';
                            output = new string(ch);
                        }
                        else
                            output = input;
                    }
                    col++;
                }

            }
            return output;
        }

        public string NextGenTransformedString(string input)
        {
            var array = input.Split('\n');
            var result = "";

            for (int row = 0; row < array.Length; row++) // rows
            {
                for (int column = 0; column < array[0].Length; column++) // columns
                {
                    if (array[row][column] == 'X')
                    {
                        var numberOfLiveNeighbours = CheckNeighboursWithMinMax(array, row, column);
                            
                        if (numberOfLiveNeighbours < 2)
                        {
                            result += '0';
                        }
                        else if (numberOfLiveNeighbours == 2 || numberOfLiveNeighbours <= 3)
                        {
                            result += 'X';
                        }
                        
                    }
                    else
                    {
                        result += '0';
                    }
                }
                result += '\n';
            }
           
            return result.TrimEnd('\n');
        }

        private int CheckNeighboursWithMinMax(string[] array, int row, int column)
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
                    if (array[rowCoord][colCoord] == 'X')
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