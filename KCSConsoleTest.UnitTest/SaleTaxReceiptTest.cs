using KCSConsoleTest.Logic;
using KCSConsoleTest.Seeder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace KCSConsoleTest.UnitTest
{
    [TestClass]
    public class SaleTaxReceiptTest
    {
        [TestMethod]
        public void PrintReceipt_FirstInput_ReturnsExpectedOutput()
        {
            ReceiptGeneration rpg = new ReceiptGeneration();
            var input = Seed.GetFirstInput();
            string expectedOutput = "1 Book: 12.49\r\n1 Music CD: 16.49\r\n1 Chocolate bar: 0.85\r\nSales Taxes: 1.50\r\nTotal: 29.83\r\n";

            using (StringWriter sw = new StringWriter())
            {
                string result = rpg.PrintReceipt(input);
                sw.WriteLine(result);
                Console.SetOut(sw);
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput.Trim(), actualOutput.Trim());
            }
        }


        [TestMethod]
        public void PrintReceipt_SecondInput_ReturnsExpectedOutput()
        {
            ReceiptGeneration rpg = new ReceiptGeneration();
            var input = Seed.GetSecondInput();
            string expectedOutput = "1 Imported box of chocolates: 10.50\r\n1 Imported bottle of perfume: 54.65\r\nSales Taxes: 7.65\r\nTotal: 65.15\r\n";

            using (StringWriter sw = new StringWriter())
            {
                string result = rpg.PrintReceipt(input);
                sw.WriteLine(result);
                Console.SetOut(sw);
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput.Trim(), actualOutput.Trim());
            }
        }

        [TestMethod]
        public void PrintReceipt_ThirdInput_ReturnsExpectedOutput()
        {
            ReceiptGeneration rpg = new ReceiptGeneration();
            var input = Seed.GetThirdInput();
            string expectedOutput = "1 Imported bottle of perfume: 32.19\r\n1 Bottle of perfume: 20.89\r\n1 Packet of paracetamol: 9.75\r\n1 Box of imported chocolates: 11.85\r\nSales Taxes: 6.70\r\nTotal: 74.68\r\n";

            using (StringWriter sw = new StringWriter())
            {
                string result = rpg.PrintReceipt(input);
                sw.WriteLine(result);
                Console.SetOut(sw);
                string actualOutput = sw.ToString();
                Assert.AreEqual(expectedOutput.Trim(), actualOutput.Trim());
            }
        }
    }
}
