using System;

using R5T.T0131;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface ISubCommands : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>ef</value></para>
        /// </summary>
        public string ef => "ef";

        /// <summary>
        /// <para><value>migrations</value></para>
        /// </summary>
        public string migrations => "migrations";

        /// <summary>
        /// <para><value>nuget</value></para>
        /// </summary>
        public string nuget => "nuget";

        /// <summary>
        /// <para><value>tool</value></para>
        /// </summary>
        public string tool => "tool";

#pragma warning restore IDE1006 // Naming Styles
    }
}
