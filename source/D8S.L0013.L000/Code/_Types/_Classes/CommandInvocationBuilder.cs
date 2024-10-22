using System;
using System.Collections.Generic;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A builder for command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public class CommandInvocationBuilder : ICommandInvocationBuilder
    {
        public string WorkingDirectoryPath { get; set; }

        /// <inheritdoc cref="Documentation.For_CommandInvocation.Command_Definition"/>
        public string Command { get; set; }

        /// <summary>
        /// Arguments by name.
        /// </summary>
        /// <remarks>
        /// The argument name is <strong>not</strong> output to the command line, but instead serves to identify the argument.
        /// </remarks>
        public IDictionary<string, IArgument> Arguments_ByArgumentName { get; } 


        public CommandInvocationBuilder()
            : this(new Dictionary<string, IArgument>())
        {
        }

        public CommandInvocationBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
        {
            this.Arguments_ByArgumentName = arguments_ByArgumentName;
        }
    }
}
