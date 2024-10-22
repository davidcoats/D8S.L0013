using System;

using R5T.T0142;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder ineterface for command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public interface IDotnetNugetCommandInvocationBuilder :
        IDotnetNugetCommandArgumentsBuilder,
        IDotnetCommandInvocationBuilder
    {

    }
}
