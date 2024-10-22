using System;

using R5T.T0131;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface ICommandInvocationArguments : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value><inheritdoc cref="IArguments.info" path="descendant::value[1]"/>, <inheritdoc cref="IArgumentNames.Info" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument info => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.info,
            ArgumentName = Instances.ArgumentNames.Info
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IArguments.list_runtimes" path="descendant::value[1]"/>, <inheritdoc cref="IArgumentNames.List_Runtimes" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument list_runtimes => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.list_runtimes,
            ArgumentName = Instances.ArgumentNames.List_Runtimes
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IArguments.list_sdks" path="descendant::value[1]"/>, <inheritdoc cref="IArgumentNames.List_Sdks" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument list_sdks => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.list_sdks,
            ArgumentName = Instances.ArgumentNames.List_Sdks
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IArguments.nuget" path="descendant::value[1]"/>, <inheritdoc cref="L000.IArgumentNames.SubCommand" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument nuget => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.nuget,
            ArgumentName = Instances.ArgumentNames.SubCommand
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IArguments.push" path="descendant::value[1]"/>, <inheritdoc cref="L000.IArgumentNames.Verb" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument push => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.push,
            ArgumentName = Instances.ArgumentNames.Verb
        };

        /// <summary>
        /// <para><value><inheritdoc cref="IArguments.version_Long" path="descendant::value[1]"/>, <inheritdoc cref="IArgumentNames.Version" path="descendant::value[1]"/></value></para>
        /// </summary>
        public CommandInvocationArgument version => new CommandInvocationArgument()
        {
            Argument = Instances.Arguments.version,
            ArgumentName = Instances.ArgumentNames.Version
        };

#pragma warning restore IDE1006 // Naming Styles
    }
}
