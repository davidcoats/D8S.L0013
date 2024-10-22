using System;

using R5T.T0131;


namespace D8S.L0013.L000
{
    [ValuesMarker]
    public partial interface ICommandInvocationArguments : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value><argument><inheritdoc cref="IArguments.help" path="descendant::value[1]"/></argument>, <inheritdoc cref="IArgumentNames.Help" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument help => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.help,
            ArgumentName = Instances.ArgumentNames.Help
        };

#pragma warning restore IDE1006 // Naming Styles
    }
}
