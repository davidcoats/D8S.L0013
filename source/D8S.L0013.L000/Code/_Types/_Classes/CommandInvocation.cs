using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// The command and argument for a command invocation.
    /// </summary>
    [DataTypeMarker, TypeMarker]
    public class CommandInvocation
    {
        /// <summary>
        /// The directory in which the command should be invoked.
        /// </summary>
        public string WorkingDirectoryPath { get; set; }

        /// <summary>
        /// The command.
        /// <para><inheritdoc cref="Documentation.For_CommandInvocation.Command_Definition" path="/summary"/></para>
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// <inheritdoc cref="Documentation.For_CommandInvocation.Argument_Definition" path="/summary"/>
        /// </summary>
        public string Argument { get; set; }
    }
}
