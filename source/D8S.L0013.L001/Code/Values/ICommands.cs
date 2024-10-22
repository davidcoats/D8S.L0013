using System;

using R5T.T0131;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface ICommands : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>dotnet</value></para>
        /// </summary>
        public string dotnet => "dotnet";

#pragma warning restore IDE1006 // Naming Styles
    }
}
