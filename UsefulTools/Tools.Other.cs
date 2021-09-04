using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static class Other
        {
            /// <summary>
            /// Closes your app.
            /// </summary>
            /// <param name="exitCode">The exit code. default is 0</param>
            public static void CloseApp(int exitCode = 0)
            {
                Environment.Exit(exitCode);
            }
        }
    }
}
