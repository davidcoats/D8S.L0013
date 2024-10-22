using System;

using R5T.T0156;


namespace D8S.L0013.L000
{
    public partial class Documentation
    {
        [DocumentationMarker]
        public partial class For_CommandInvocation
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
