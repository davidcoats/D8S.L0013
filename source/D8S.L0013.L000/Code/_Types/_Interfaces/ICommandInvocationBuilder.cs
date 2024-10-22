using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A builder ineterface for command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public interface ICommandInvocationBuilder : ICommandArgumentsBuilder
    {
        /// <summary>
        /// The directory in which a command should be invoked.
        /// </summary>
        string WorkingDirectoryPath { get; set; }

        /// <inheritdoc cref="Documentation.For_CommandInvocation.Command_Definition"/>
        string Command { get; set; }
    }
}
