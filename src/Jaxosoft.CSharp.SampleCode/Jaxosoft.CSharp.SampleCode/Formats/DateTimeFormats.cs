using Jaxosoft.CSharp.SampleCode.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jaxosoft.CSharp.SampleCode.Formats
{
    /// <summary>
    /// The things I can NEVER remember!!!
    /// https://github.com/dotnet/coreclr/blob/master/src/System.Private.CoreLib/shared/System/Globalization/DateTimeFormat.cs
    /// </summary>
    public static class DateTimeFormats
    {
        public static readonly List<List<string>> CultureSpecificFormats = new List<List<string>>
            {
                new List<string> {"d", "short date", String.Empty},
                new List<string> {"D", "long date", String.Empty},
                new List<string> {"f", "full date (long date + short time)", String.Empty},
                new List<string> {"F", "full date (long date + long time)", String.Empty},
                new List<string> {"g", "general date (short date + short time)", String.Empty},
                new List<string> {"G", "general date (short date + long time)", String.Empty},
                new List<string> {"m", "Month/Day date", String.Empty},
                new List<string> {"M", "Month/Day date", String.Empty},
                new List<string> {"t", "short time", String.Empty},
                new List<string> {"T", "long time", String.Empty},
                new List<string> {"U", "UTC full (long date + long time)", String.Empty},
                new List<string> {"y", "Year/Month day", String.Empty},
                new List<string> {"Y", "Year/Month day", String.Empty}
            };

        public static readonly List<List<string>> NonCultureSpecificFormats = new List<List<string>>
            {
                new List<string> {"o", "Round Trip XML", String.Empty},
                new List<string> {"O", "Round Trip XML", String.Empty},
                new List<string> {"r", "RFC 1123 date", String.Empty},
                new List<string> {"R", "RFC 1123 date", String.Empty},
                new List<string> {"s", "ISO 8601 (sortable)", String.Empty},
                new List<string> {"u", "ISO 8601 UTC (sortable)", String.Empty}
            };

        public static readonly List<List<string>> RawFormatCharacters = new List<List<string>>
            {
                new List<string> {"h", "hour (12-hour clock)w/o leading zero", String.Empty},
                new List<string> {"hh", "hour (12-hour clock)with leading zero", String.Empty},
                new List<string> {"hh*", "hour (12-hour clock)with leading zero", String.Empty},
                new List<string> {"H", "hour (24-hour clock)w/o leading zero", String.Empty},
                new List<string> {"HH", "hour (24-hour clock)with leading zero", String.Empty},
                new List<string> {"HH*", "hour (24-hour clock)", String.Empty},
                new List<string> {"m", "minute w/o leading zero", String.Empty},
                new List<string> {"mm", "minute with leading zero", String.Empty},
                new List<string> {"mm*", "minute with leading zero", String.Empty},
                new List<string> {"s", "second w/o leading zero", String.Empty},
                new List<string> {"ss", "second with leading zero", String.Empty},
                new List<string> {"ss*", "second with leading zero", String.Empty},
                new List<string> {"f", "second fraction (1 digit)", String.Empty},
                new List<string> {"ff", "second fraction (2 digit)", String.Empty},
                new List<string> {"fff", "second fraction (3 digit)", String.Empty},
                new List<string> {"ffff", "second fraction (4 digit)", String.Empty},
                new List<string> {"fffff", "second fraction (5 digit)", String.Empty},
                new List<string> {"ffffff", "second fraction (6 digit)", String.Empty},
                new List<string> {"fffffff", "second fraction (7 digit)", String.Empty},
                new List<string> {"F", "second fraction (up to 1 digit)", String.Empty},
                new List<string> {"FF", "second fraction (up to 2 digit)", String.Empty},
                new List<string> {"FFF", "second fraction (up to 3 digit)", String.Empty},
                new List<string> {"FFFF", "second fraction (up to 4 digit)", String.Empty},
                new List<string> {"FFFFF", "second fraction (up to 5 digit)", String.Empty},
                new List<string> {"FFFFFF", "second fraction (up to 6 digit)", String.Empty},
                new List<string> {"FFFFFFF", "second fraction (up to 7 digit)", String.Empty},
                new List<string> {"t", "first character of AM/PM designator", String.Empty},
                new List<string> {"tt", "AM/PM designator", String.Empty},
                new List<string> {"tt*", "AM/PM designator", String.Empty},
                new List<string> {"d", "day w/o leading zero", String.Empty},
                new List<string> {"dd", "day with leading zero", String.Empty},
                new List<string> {"ddd", "short weekday name (abbreviation)", String.Empty},
                new List<string> {"dddd", "full weekday name", String.Empty},
                new List<string> {"dddd*", "full weekday name", String.Empty},
                new List<string> {"M", "month w/o leading zero", String.Empty},
                new List<string> {"MM", "month with leading zero", String.Empty},
                new List<string> {"MMM", "short month name (abbreviation)", String.Empty},
                new List<string> {"MMMM", "full month name", String.Empty},
                new List<string> {"MMMM*", "full month name", String.Empty},
                new List<string> {"y", "two digit year (year % 100) w/o leading zero", String.Empty},
                new List<string> {"yy", "two digit year (year % 100) with leading zero", String.Empty},
                new List<string> {"yyy", "year", String.Empty},
                new List<string> {"yyyy", "year", String.Empty},
                new List<string> {"yyyyy", "year", String.Empty},
                new List<string> {"z", "timezone offset w/o leading zero", String.Empty},
                new List<string> {"zz", "timezone offset with leading zero", String.Empty},
                new List<string> {"zzz", "full timezone offset", String.Empty},
                new List<string> {"zzz*", "full timezone offset", String.Empty},
                new List<string> {"K", "???", String.Empty},
                new List<string> {"g*", "the current era name", String.Empty},
                new List<string> {"00:00:00", "time separator", String.Empty},
                new List<string> {"dd/mm/yyyy", "date separator", String.Empty},
                new List<string> {"yyyy-mm-dd", "date separator", String.Empty},
                new List<string> {"'ABC'", "quoted string", String.Empty},
                new List<string> {"\"ABC\"", "quoted string", String.Empty},
                new List<string> {"%yyyy", "used to quote a single pattern characters", String.Empty},
                new List<string> {"\\d", "escaped character", String.Empty}
            };

        public static void PrintTable()
        {
            CalculateToString(CultureSpecificFormats);
            CalculateToString(NonCultureSpecificFormats);
            CalculateToString(RawFormatCharacters);

            Console.WriteLine("CultureSpecificFormats");
            foreach (var line in StringFixedWidthPrinter.MakeFixedWidthStrings(CultureSpecificFormats))
                Console.WriteLine(line);

            Console.WriteLine("NonCultureSpecificFormats");
            foreach (var line in StringFixedWidthPrinter.MakeFixedWidthStrings(NonCultureSpecificFormats))
                Console.WriteLine(line);

            Console.WriteLine("RawFormatCharacters");
            foreach (var line in StringFixedWidthPrinter.MakeFixedWidthStrings(RawFormatCharacters))
                Console.WriteLine(line);
        }

        private static void CalculateToString(List<List<string>> data)
        {
            var now = DateTime.Now;

            foreach (var list in data)
                list[2] = now.ToString(list[0]);
        }
    }
}
