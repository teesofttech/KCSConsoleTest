using KCSConsoleTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSConsoleTest.Logic
{
    public class TaxCalculation
    {

        public static double CalculateTax(string[] parts)
        {
            double taxRate = IsTaxExempt(parts) ? 0 : 0.1; // Basic tax rate is 10%
            if (IsImported(parts))
                taxRate += 0.05; // Imported goods have an additional 5% tax

            double price = double.Parse(parts[parts.Length - 1]);
            double tax = Math.Ceiling(price * taxRate * 20) / 20; // Round up to the nearest 0.05
            return tax;
        }

        private static bool IsTaxExempt(string[] parts)
        {
            var nameExtractor = new NameExtractor();
            string[] exemptedItems = { "book", "books", "food", "chocolate", "chocolates", "paracetamol", "medicine" };
            string itemName = nameExtractor.ItemName(parts).ToLower();

            foreach (string exemptedItem in exemptedItems)
            {
                if (itemName.Contains(exemptedItem))
                    return true;
            }

            return false;
        }

        private static bool IsImported(string[] parts)
        {
            return Array.Exists(parts, s => s.ToString().Equals("Imported", StringComparison.OrdinalIgnoreCase));
        }

    }
}
