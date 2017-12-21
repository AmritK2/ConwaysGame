using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGame
{
    class ConwaysConsoled
    {
        static void Main(string[] args)
        {
            string input = "*****\n" +
                           "**11*\n" +
                           "*11**\n" +
                           "**1**\n" +
                           "*****";
            while (true)
            {
                Pattern pattern = new Pattern();
                var result = pattern.TransformedCellString(input);

                while (result != input)
                {
                    Console.WriteLine(result);
                    Console.WriteLine("---------");
                    input = result;
                }

            }

        }
    }
}
