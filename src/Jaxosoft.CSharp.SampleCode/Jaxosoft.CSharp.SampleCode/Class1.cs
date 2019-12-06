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
using Jaxosoft.CSharp.SampleCode.Formats;

/*
NOTES for .NET Core:
    The following NuGet packages may need to be installed to enable certain features.
        System.Dynamic.Runtime(for dynamic keyword and ExpandoObject)
        System.Reflection
        System.Runtime
        System.ValueTuple
        System.IO.FileSystem
        Microsoft.Windows.Compatibility(WMI, System.Drawing[aka.GDI +], etc.)

    Open the Package Management window in Visual Studio and paste the following, as required.
        Install-Package System.Runtime
        Install-Package System.Dynamic.Runtime
        Install-Package System.ValueTuple
        Install-Package System.Reflection
        Install-Package System.IO.FileSystem
        Install-Package System.Console
*/

namespace Jaxosoft.CSharp.SampleCode
{
    public class Class1
    {
        /// <summary>
        /// I'm documenting this because I always forget the order of the
        /// tokens in the definition.  Supported in C# 7.1+
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<int> Main(string[] args)
        {
            // your code here

            Console.ReadLine();
            Console.WriteLine("Press ENTER to exit.");

            return 0;
        }
    }
}
