using KCSConsoleTest.Utilities;
using System.Collections.Generic;
using System.Text;

namespace KCSConsoleTest.Logic
{
    public class ReceiptGeneration
    {
        public string PrintReceipt(List<string> input)
        {
            double totalTax = 0;
            double totalPrice = 0;
            StringBuilder sb = new StringBuilder();
            NameExtractor extractor = new NameExtractor();
            foreach (string item in input)
            {
                string[] parts = item.Split(' ');
                int quantity = int.Parse(parts[0]);
                string dd = parts[parts.Length - 1];
                double price = double.Parse(parts[parts.Length - 1]);
                double tax = TaxCalculation.CalculateTax(parts);

                double itemTotal = quantity * (price + tax);
                totalTax += quantity * tax;
                totalPrice += itemTotal;

                sb.AppendLine($"{quantity} {extractor.ItemName(parts)}: {itemTotal:F2}");
            }

            sb.AppendLine($"Sales Taxes: {totalTax:F2}");
            sb.AppendLine($"Total: {totalPrice:F2}");

            return sb.ToString();
        }
    }
}
