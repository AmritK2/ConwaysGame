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
            string input = "00000\n" +
                           "00XX0\n" +
                           "0XX00\n" +
                           "00X00\n" +
                           "00000";
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
