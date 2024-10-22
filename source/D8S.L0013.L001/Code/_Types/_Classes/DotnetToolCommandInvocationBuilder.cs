using System;
using System.Collections.Generic;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder for dotnet tool command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public class DotnetToolCommandInvocationBuilder : DotnetCommandInvocationBuilder,
        IDotnetToolCommandInvocationBuilder
    {
        public DotnetToolCommandInvocationBuilder()
            : base()
        {
        }

        public DotnetToolCommandInvocationBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            : base(arguments_ByArgumentName)
        {
        }
    }
}
