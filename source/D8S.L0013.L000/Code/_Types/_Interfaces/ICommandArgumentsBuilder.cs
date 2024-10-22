using System;
using System.Collections.Generic;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A builder interface for command arguments.
    /// </summary>
    [UtilityTypeMarker]
    public interface ICommandArgumentsBuilder
    {
        IDictionary<string, IArgument> Arguments_ByArgumentName { get; }
    }
}
