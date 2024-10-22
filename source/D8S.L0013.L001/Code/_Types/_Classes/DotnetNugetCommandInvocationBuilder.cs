using System;
using System.Collections.Generic;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder for dotnet nuget command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public class DotnetNugetCommandInvocationBuilder : DotnetCommandInvocationBuilder,
        IDotnetNugetCommandInvocationBuilder
    {
        public DotnetNugetCommandInvocationBuilder()
            : base()
        {
        }

        public DotnetNugetCommandInvocationBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            : base(arguments_ByArgumentName)
        {
        }
    }
}
