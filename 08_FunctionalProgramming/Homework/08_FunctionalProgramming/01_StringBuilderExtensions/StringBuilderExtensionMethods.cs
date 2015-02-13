using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_StringBuilderExtensionMethods
{
    public static class StringBuilderExtensionMethods
    {
        public static string Substring(this StringBuilder stringBuilder,int startIndex, int length)
        {
            return stringBuilder.ToString(startIndex, length);
        }

        public static string RemoveText(this StringBuilder stringBuilder, string text)
        {
            return Regex.Replace(stringBuilder.ToString().Trim(), text, "", RegexOptions.IgnoreCase).Trim();
        }

        public static string AppendAll<T>(this StringBuilder stringBuilder, IEnumerable<T> items)
        {
            return string.Join(", ", items);
        }
    }
}
