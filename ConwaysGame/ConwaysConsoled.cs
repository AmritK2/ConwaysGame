using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConwaysGame
{
    class ConwaysConsoled
    {
        static void Main(string[] args)
        {
            string input = "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "************11***********\n" +
                           "***********11************\n" +
                           "************1************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************\n" +
                           "*************************";
            while (true)
            {
                CheckingCells pattern = new CheckingCells();
                var result = pattern.TransformedCellString(input);


                while (result != input)
                {
                    Console.WriteLine(result);
                    input = result;
 
                }
                Thread.Sleep(1000);

                Console.Clear();
            }

        }
    }
}
