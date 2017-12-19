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

        public string UnderPopulationDeathShouldReturn(string input)
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
                        output = result < 2 ? "dead" : "alive";
                    }
                    c++;
                }
               
            }
            return output;
        }

        private int CheckNeighbours(string input, int i, int j)
        {
            int count = 0;
        
            if (i < input.Length-1)
            {
                if (input[(i - 1)] == 'X' && input[j - 1] == 'X')
                {
                    count++;
                }
                else if (input[(i - 1)] == 'X')
                {
                    count++;
                }
                else if (input[(i - 1)] == 'X' && input[j + 1] == 'X')
                {
                    count++;
                }
                else if (input[(i + 1)] == 'X')
                {
                    count++;
                }
                else if (input[(i + 1)] == 'X' && input[j + 1] == 'X')
                {
                    count++;
                }
                else if (input[(i + 1)] == 'X')
                {
                    count++;
                }
                else if (input[(i + 1)] == 'X' && input[j - 1] == 'X')
                {
                    count++;
                }
                else if (input[j - 1] == 'X')
                {
                    count++;
                }
            }
            return count;
        }


        public string UnderPopulationTransformedString(string input)
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
                        else
                            output = input;
                    }
                    c++;
                }

            }
            return output;
        }

        public string NextGenTransformedString(string input)
        {
            throw new NotImplementedException();
        }
    }
}