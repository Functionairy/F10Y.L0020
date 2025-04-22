using System;

using F10Y.T0001;


namespace F10Y.L0020
{
    public static partial class Documentation
    {
        [DocumentationsMarker]
        public static partial class For_CommandInvocation
        {
            /// <summary>
            /// The arguments for the command, concatenated into a single string.
            /// </summary>
            public static readonly object Argument_Definition;

            /// <summary>
            /// Either the name of an executable on the path, like "dotnet", or the path of an executable file.
            /// </summary>
            public static readonly object Command_Definition;
        }
    }
}
