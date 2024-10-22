using System;
using System.Collections.Generic;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder for donet nuget command arguments.
    /// </summary>
    [UtilityTypeMarker]
    public class DotnetNugetCommandArgumentsBuilder : DotnetCommandArgumentsBuilder,
        IDotnetNugetCommandArgumentsBuilder
    {
        public DotnetNugetCommandArgumentsBuilder()
            : base()
        {
        }

        public DotnetNugetCommandArgumentsBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            :base(arguments_ByArgumentName)
        {
        }
    }
}
