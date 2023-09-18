using KCSConsoleTest.Logic;
using KCSConsoleTest.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReceiptGeneration rpg = new ReceiptGeneration();

            Console.WriteLine("***********  Sales Taxes ***********");
            Console.WriteLine();

            Console.WriteLine("Output 1:");
            Console.WriteLine(rpg.PrintReceipt(Seed.GetFirstInput()));
            Console.WriteLine();


            Console.WriteLine("Output 2:");
            Console.WriteLine(rpg.PrintReceipt(Seed.GetSecondInput()));
            Console.WriteLine();

            Console.WriteLine("Output 3:");
            Console.WriteLine(rpg.PrintReceipt(Seed.GetThirdInput()));

            Console.ReadKey();
        }

    }
}
