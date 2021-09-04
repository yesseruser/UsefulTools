using System;

namespace UsefulTools
{
    public partial class Tools
    {
        public static class Other
        {
            public static void CloseApp(int exitCode)
            {
                Environment.Exit(exitCode);
            }
        }
    }
}
