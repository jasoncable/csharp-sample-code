using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jaxosoft.CSharp.SampleCode.Helpers
{
    /// <summary>
    /// This sample shows how to wrap an async method call in a console app (or any application)
    /// so that it will automatically print to the console a description of the method being
    /// run and so that it will magically time the call also, printing start time, end time,
    /// and duration.
    ///
    /// This can also be done synchronously.  I'm showing the async version here as it's syntax
    /// is a little weird.
    /// </summary>
    public static class ConsoleLogging
    {
        public static async Task<int> HowToRunThis()
        {
            await TimeExecutionAndLog( "MyMethodToRun()", async () =>
                {
                    await MyMethodToRun();
                }
            );

            return 0;
        }

        internal static Logger Logger { get; set; }

        public static async Task<bool> TimeExecutionAndLog(string description, Action action)
        {
            Logger = LogManager.GetCurrentClassLogger();

            DateTime start = DateTime.Now;
            Logger.Debug($"Begin Invoke: {description}, {start.ToString("o")}");
            bool errored = false;

            try
            {
                action.Invoke();
            }
            catch (Exception exc)
            {
                Logger.Error(exc, $"ERROR in {description}!");
            }
            finally
            {
                DateTime end = DateTime.Now;
                Logger.Debug($"End Invoke:   {description}, {end.ToString("o")}");
                TimeSpan duration = end - start;
                Logger.Info($"Time to Run:  {description}, {(int)duration.TotalHours}h {duration.Minutes}m {duration.Seconds}s {duration.Milliseconds}ms");
            }

            return !errored;
        }

        public static async Task<List<string>> MyMethodToRun()
        {
            return new List<string>();
        }
    }
}
