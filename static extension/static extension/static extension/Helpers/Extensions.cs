using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace static_extension.Helpers
{
    public static class Extensions
    {
        public static bool CheckDigit(string str)
        {
            return Regex.IsMatch(str,@"\d);
        }
    }
}
