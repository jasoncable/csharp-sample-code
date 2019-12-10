using System;
using System.Collections.Generic;
using System.Text;

namespace Jaxosoft.CSharp.SampleCode.Helpers
{
    public static class StringFixedWidthPrinter
    {
        public static List<string> MakeFixedWidthStrings(List<List<string>> strings)
        {
            List<string> output = new List<string>();
            List<int> widths = new List<int>();

            foreach(var stringList in strings)
            {
                for(int i = 0; i < stringList.Count; i++)
                {
                    if (widths.Count <= i)
                        widths.Add(0);
                    if (stringList[i] != null && widths[i] < stringList[i].Length)
                        widths[i] = stringList[i].Length;
                }
            }

            // header row
            StringBuilder sb = new StringBuilder();
            foreach (var width in widths)
            {
                sb.Append(String.Empty.PadRight(width, '='));
                sb.Append(' ');
            }
            output.Add(sb.ToString());

            foreach (var stringList in strings)
            {
                StringBuilder sb1 = new StringBuilder();
                for (int i = 0; i < widths.Count; i++)
                {
                    var width = widths[i];
                    if (stringList.Count >= i)
                    {
                        if (String.IsNullOrEmpty(stringList[i]))
                            sb1.Append(String.Empty.PadRight(width + 1, ' '));
                        else
                            sb1.Append(stringList[i].PadRight(width + 1, ' '));
                    }
                    else
                    {
                        sb1.Append(String.Empty.PadRight(width + 1, ' '));
                    }
                }
                output.Add(sb1.ToString());
            }
            output.Add(String.Empty);
            return output;
        }
    }
}
