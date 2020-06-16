using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class StringExtensions
    {
        public static string SafeSubstringNullable(this string input, int startIndex, int? length = null)
        {
            if (input == null || input.Length == 0 || startIndex > input.Length - 1)
                return null;

            if (length == null)
            {
                return input.Substring(startIndex);
            }
            else
            {
                if (startIndex - 1 + length >= input.Length)
                    return input.Substring(startIndex);
                else
                    return input.Substring(startIndex, length.Value);
            }
        }

        public static string SafeSubstringNonNull(this string input, int startIndex, int? length = null)
        {
            if (input == null || input.Length == 0 || startIndex > input.Length - 1)
                return string.Empty;

            if (length == null)
            {
                return input.Substring(startIndex);
            }
            else
            {
                if (startIndex - 1 + length >= input.Length)
                    return input.Substring(startIndex);
                else
                    return input.Substring(startIndex, length.Value);
            }
        }
    }
}
