using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A command invocation argument.
    /// </summary>
    [DataTypeMarker, UtilityTypeMarker]
    public interface IArgument
    {
        /// <summary>
        /// Gets the text representation of the argument for use at the command line.
        /// </summary>
        string Get_ArgumentText();
    }
}
