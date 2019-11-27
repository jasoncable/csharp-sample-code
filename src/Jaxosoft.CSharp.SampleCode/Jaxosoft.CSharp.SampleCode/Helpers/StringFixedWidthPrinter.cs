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
            foreach (var width in widths)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(String.Empty.PadRight(width, '='));
                sb.Append(' ');
                output.Add(sb.ToString());
            }

            foreach (var stringList in strings)
            {
                foreach(var width in widths)
                {
                    for(int i = 0; i < stringList.Count; i++)
                    {
                        StringBuilder sb = new StringBuilder();

                        if (String.IsNullOrEmpty(stringList[i]))
                            sb.Append(String.Empty.PadRight(width + 1, ' '));
                        else
                            sb.Append(stringList[i].PadRight(width + 1, ' '));

                        output.Add(sb.ToString());
                    }
                }
            }
            return output;
        }
    }
}
