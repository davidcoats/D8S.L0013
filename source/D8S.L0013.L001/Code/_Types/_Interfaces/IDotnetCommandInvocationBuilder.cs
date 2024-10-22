using System;

using R5T.T0142;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    /// <summary>
    /// A builder ineterface for command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public interface IDotnetCommandInvocationBuilder :
        IDotnetCommandArgumentsBuilder,
        ICommandInvocationBuilder
    {

    }
}
