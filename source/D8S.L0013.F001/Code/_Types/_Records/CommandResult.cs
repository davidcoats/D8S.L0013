using System;

using R5T.T0142;
using R5T.T0253.T000;


namespace D8S.L0013.F001
{
    [DataTypeMarker]
    public record CommandResult(
        string[] OutputLines,
        string[] ErrorLines,
        int ExitCode,
        TimeSpan Duration
        ) :
        IHasOutputLines,
        IHasErrorLines,
        IHasExitCode,
        IHasDuration
    {
    }
}


namespace D8S.L0013.F001.N001
{
    [DataTypeMarker]
    public record CommandResult(
        int ExitCode,
        TimeSpan Duration
        ) :
        IHasExitCode,
        IHasDuration
    {
    }
}