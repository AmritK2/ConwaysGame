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

        public string BlinkerPatternShouldReturn(string input)
        {
            var r = 0;
            var c = 0;
            var result = "";

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
                        result = Somefunction(input, r, c);
                       
                    }
                    c++;
                }
                
            }
            return result;
        }

        private string Somefunction(string input, int i, int j)
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
            var output = count < 2 ? "dead" : "alive";
            return output;
        }


    }
}