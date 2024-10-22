using System;
using System.Collections.Generic;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder for dotnet command arguments.
    /// </summary>
    [UtilityTypeMarker]
    public class DotnetCommandArgumentsBuilder : CommandArgumentsBuilder,
        IDotnetCommandArgumentsBuilder
    {
        public DotnetCommandArgumentsBuilder()
            : base()
        {
        }

        public DotnetCommandArgumentsBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            :base(arguments_ByArgumentName)
        {
        }
    }
}
