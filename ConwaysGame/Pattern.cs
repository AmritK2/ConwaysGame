using System;
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
            var r = 0;
            var c = 0;
            var output = "";
            
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '\n')
                    {
                        c = 0;
                        r++;
                    }
                    else if (input[j] == 'X')
                    {
                        var result = CheckNeighbours(input, r, c);
                        if (result < 2)
                        {
                            char[] ch = input.ToCharArray();
                            ch[j] = '0';
                            output = new string(ch);
                            
                        }
                        else if (result == 2 || result <= 3)
                        {
                            char[] ch = input.ToCharArray();
                            ch[j] = 'X';
                            output = new string(ch);
                        }
                        
                    }
                    c++;
                }
            }
            return output;
        }


    }
}