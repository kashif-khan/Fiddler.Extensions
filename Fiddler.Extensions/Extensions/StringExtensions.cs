using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiddler.Extensions.Extensions
{
    static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string Value)
        {
            return string.IsNullOrEmpty(Value);
        }
        public static bool IsNullOrWhiteSpace(this string Value)
        {
            return string.IsNullOrWhiteSpace(Value);
        }
        public static bool IsNotNullOrEmpty(this string Value)
        {
            return !string.IsNullOrEmpty(Value);
        }
        public static bool IsNotNullOrWhiteSpace(this string Value)
        {
            return !string.IsNullOrWhiteSpace(Value);
        }
        public static bool Contains(this string source, string value, StringComparison comparisonType)
        {
            return source?.IndexOf(value, comparisonType) >= 0;
        }
    }
}
