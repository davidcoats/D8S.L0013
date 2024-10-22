using System;

using R5T.T0131;

using D8S.L0013.L000;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface IArguments : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value><inheritdoc cref="R5T.L0066.IStrings.DoubleDash" path="descendant::value"/><inheritdoc cref="IOptionNames.info" path="descendant::value"/></value></para>
        /// </summary>
        public OptionFlagArgument_Long info => Instances.CommandInvocationOperator.Get_OptionFlag_Long(
            Instances.OptionNames.info);

        /// <summary>
        /// <para><value><inheritdoc cref="R5T.L0066.IStrings.DoubleDash" path="descendant::value"/><inheritdoc cref="IOptionNames.list_runtimes" path="descendant::value"/></value></para>
        /// </summary>
        public OptionFlagArgument_Long list_runtimes => Instances.CommandInvocationOperator.Get_OptionFlag_Long(
            Instances.OptionNames.list_runtimes);

        /// <summary>
        /// <para><value><inheritdoc cref="R5T.L0066.IStrings.DoubleDash" path="descendant::value"/><inheritdoc cref="IOptionNames.list_sdks" path="descendant::value"/></value></para>
        /// </summary>
        public OptionFlagArgument_Long list_sdks => Instances.CommandInvocationOperator.Get_OptionFlag_Long(
            Instances.OptionNames.list_sdks);

        /// <summary>
        /// <para><value><inheritdoc cref="ISubCommands.nuget" path="descendant::value"/></value></para>
        /// </summary>
        public SubCommandArgument nuget => Instances.CommandInvocationOperator.Get_Subcommand(
            Instances.SubCommands.nuget);

        /// <summary>
        /// <para><value><inheritdoc cref="IVerbs.pack" path="descendant::value"/></value></para>
        /// </summary>
        public VerbArgument pack => Instances.CommandInvocationOperator.Get_Verb(
            Instances.Verbs.pack);

        /// <summary>
        /// <para><value><inheritdoc cref="IVerbs.push" path="descendant::value"/></value></para>
        /// </summary>
        public VerbArgument push => Instances.CommandInvocationOperator.Get_Verb(
            Instances.Verbs.push);

        /// <summary>
        /// <para><value><inheritdoc cref="ISubCommands.tool" path="descendant::value"/></value></para>
        /// </summary>
        public SubCommandArgument tool => Instances.CommandInvocationOperator.Get_Subcommand(
            Instances.SubCommands.tool);

        /// <summary>
        /// <para><value><inheritdoc cref="R5T.L0066.IStrings.DoubleDash" path="descendant::value"/><inheritdoc cref="IOptionNames.version" path="descendant::value"/></value></para>
        /// </summary>
        public OptionFlagArgument_Long version_Long => Instances.CommandInvocationOperator.Get_OptionFlag_Long(
            Instances.OptionNames.version);

        /// <inheritdoc cref="version_Long"/>
        public OptionFlagArgument_Long version => this.version_Long;

#pragma warning restore IDE1006 // Naming Styles
    }
}
