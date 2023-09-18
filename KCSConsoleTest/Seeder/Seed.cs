using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSConsoleTest.Seeder
{
    public static class Seed
    {
        public static List<string> GetFirstInput()
        {
            return new List<string>
            {
                "1 Book at 12.49",
                "1 Music CD at 14.99",
                "1 Chocolate bar at 0.85"
            };
        }

        public static List<string> GetSecondInput()
        {
            return new List<string>
            {
                "1 Imported box of chocolates at 10.00",
                "1 Imported bottle of perfume at 47.50"
            };

        }

        public static List<string> GetThirdInput()
        {
            return new List<string>
            {
                "1 Imported bottle of perfume at 27.99",
                "1 Bottle of perfume at 18.99",
                "1 Packet of paracetamol at 9.75",
                "1 Box of imported chocolates at 11.25"
            };
        }
    }
}
