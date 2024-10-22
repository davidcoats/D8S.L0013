using System;
using System.Collections.Generic;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder for dotnet tool command arguments.
    /// </summary>
    [UtilityTypeMarker]
    public class DotnetToolCommandArgumentsBuilder : DotnetCommandArgumentsBuilder,
        IDotnetToolCommandArgumentsBuilder
    {
        public DotnetToolCommandArgumentsBuilder()
            : base()
        {
        }

        public DotnetToolCommandArgumentsBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            :base(arguments_ByArgumentName)
        {
        }
    }
}
