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

using FluentAssertions.Common;
using FluentAssertions;

namespace Jaxosoft.CSharp.SampleCode.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Jaxosoft.CSharp.SampleCode.Formats.DateTimeFormats.PrintTable();

            string test = "FooBar";
            test.SafeSubstringNullable(0).Should().Be("FooBar");
            test.SafeSubstringNullable(0, 2).Should().Be("Fo");
            test.SafeSubstringNullable(1, 3).Should().Be("ooB");
            test.SafeSubstringNullable(5, 100).Should().Be("r");
            test.SafeSubstringNullable(0, 20).Should().Be("FooBar");
            test.SafeSubstringNullable(10, 1).Should().BeNull();

            Console.WriteLine("Press ENTER to exit!");
            Console.ReadLine();
        }
    }
}
