using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSConsoleTest.Utilities
{
    public class NameExtractor
    {
        public string ItemName(string[] parts)
        {
            int endIndex = parts.Length - 3;
            return string.Join(" ", parts, 1, endIndex);
        }
    }
}
