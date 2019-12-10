using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Jaxosoft.CSharp.SampleCode.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Jaxosoft.CSharp.SampleCode.Formats.DateTimeFormats.PrintTable();

            Console.WriteLine("Press ENTER to exit!");
            Console.ReadLine();
        }
    }
}
