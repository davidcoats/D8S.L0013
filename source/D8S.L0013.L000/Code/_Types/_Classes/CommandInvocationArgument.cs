using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// The command and argument for a command invocation.
    /// </summary>
    [DataTypeMarker, TypeMarker]
    public class CommandInvocationArgument
    {
        /// <summary>
        /// The name for the argument.
        /// </summary>
        public string ArgumentName { get; set; }

        /// <summary>
        /// The argument.
        /// </summary>
        public IArgument Argument { get; set; }
    }
}
