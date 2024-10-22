using System;
using System.Collections.Generic;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder for dotnet command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public class DotnetCommandInvocationBuilder : CommandInvocationBuilder,
        IDotnetCommandInvocationBuilder
    {
        public DotnetCommandInvocationBuilder()
            : base()
        {
        }

        public DotnetCommandInvocationBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            : base(arguments_ByArgumentName)
        {
        }
    }
}
