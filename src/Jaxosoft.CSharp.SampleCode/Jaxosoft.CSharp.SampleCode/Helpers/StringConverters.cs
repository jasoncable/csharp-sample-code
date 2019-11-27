using System;
using System.Collections.Generic;
using System.Text;

namespace Jaxosoft.CSharp.SampleCode.Helpers
{
    /// <summary>
    /// Mostly stupid shit that I never remember how to do.  :)
    /// </summary>
    public static class StringConverters
    {
        public static string ConvertFromBase64StringToString(string str)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }
    }
}
