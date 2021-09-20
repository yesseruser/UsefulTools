﻿using System;

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
            /// <summary>
            /// Returns any input you give it.
            /// </summary>
            /// <typeparam name="T">The type of the thing to output and the output itself</typeparam>
            /// <param name="thing">The thing to output</param>
            /// <returns>The parameter given</returns>
            public static T ReturnInput<T>(T thing) => thing;
            public static void ThrowStackOverflowException()
            {
                ThrowStackOverflowException();
            }
        }
    }
}
