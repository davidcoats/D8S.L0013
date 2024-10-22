using System;

using R5T.T0131;


namespace D8S.L0013.L000
{
    [ValuesMarker]
    public partial interface IArguments : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value><inheritdoc cref="R5T.L0066.IStrings.DoubleDash" path="descendant::value"/><inheritdoc cref="IOptionNames.help" path="descendant::value"/></value></para>
        /// </summary>
        public OptionFlagArgument_Long help_Long => Instances.CommandInvocationOperator.Get_OptionFlag_Long(
            Instances.OptionNames.help);

        /// <inheritdoc cref="help_Long"/>
        public OptionFlagArgument_Long help => this.help_Long;

        /// <summary>
        /// <para><value><inheritdoc cref="R5T.L0066.IStrings.Dash" path="descendant::value"/><inheritdoc cref="IOptionNames.h" path="descendant::value"/></value></para>
        /// </summary>
        public OptionFlagArgument_Short help_Short => Instances.CommandInvocationOperator.Get_OptionFlag_Short(
            Instances.OptionNames.h);

        /// <inheritdoc cref="help_Short"/>
        public OptionFlagArgument_Short h => this.help_Short;

#pragma warning restore IDE1006 // Naming Styles
    }
}
