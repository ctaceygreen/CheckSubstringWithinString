using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSubstringWithinString
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool CheckSubstringWithinString(string substring, string fullString)
        {
            return fullString.Contains(substring);
        }
    }
}
