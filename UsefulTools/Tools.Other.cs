using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static class Other
        {
            public static void CloseApp(int exitCode = 0)
            {
                Environment.Exit(exitCode);
            }
        }
    }
}
