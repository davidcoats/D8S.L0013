using System;

using R5T.T0142;
using R5T.T0253.T000;


namespace D8S.L0013.F001
{
    [DataTypeMarker]
    public record CommandInput(
        string Command,
        string CommandArgument
        ) :
        IHasCommand,
        IHasCommandArgument
    {
    }
}
