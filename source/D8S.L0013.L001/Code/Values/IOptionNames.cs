using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface IOptionNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public ISubCommands _Subcommands => SubCommands.Instance;

#pragma warning restore IDE1006 // Naming Styles


#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>api-key</value></para>
        /// </summary>
        public string api_key => "api-key";

        /// <summary>
        /// <para><value>g</value></para>
        /// </summary>
        public string g => "g";

        /// <summary>
        /// <para><value>global</value></para>
        /// </summary>
        public string global => "global";

        /// <summary>
        /// <para><value>info</value></para>
        /// </summary>
        public string info => "info";

        /// <summary>
        /// <para><value>list-runtimes</value></para>
        /// </summary>
        public string list_runtimes => "list-runtimes";

        /// <summary>
        /// <para><value>list-sdks</value></para>
        /// </summary>
        public string list_sdks => "list-sdks";

        /// <inheritdoc cref="ISubCommands.nuget"/>>
        public string nuget => _Subcommands.nuget;

        /// <summary>
        /// <para><value>pack</value></para>
        /// </summary>
        public string pack => "pack";

        /// <summary>
        /// <para><value>push</value></para>
        /// </summary>
        public string push => "push";

        /// <summary>
        /// <para><value>source</value></para>
        /// </summary>
        public string source => "source";

        /// <summary>
        /// <para><value>version</value></para>
        /// </summary>
        public string version => "version";

#pragma warning restore IDE1006 // Naming Styles
    }
}
