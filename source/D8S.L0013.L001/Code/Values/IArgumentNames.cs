using System;

using R5T.T0131;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface IArgumentNames : IValuesMarker,
        L000.IArgumentNames
    {
        /// <summary>
        /// <para><value>API-Key</value></para>
        /// </summary>
        public string API_Key => "API-Key";

        /// <summary>
        /// <para><value>EFCore-Command</value></para>
        /// </summary>
        public string EFCore_Command => "EFCore-Command";

        /// <summary>
        /// <para><value>Global</value></para>
        /// </summary>
        public string Global => "Global";

        /// <summary>
        /// <para><value>Info</value></para>
        /// </summary>
        public string Info => "Info";

        /// <summary>
        /// <para><value>List-Runtimes</value></para>
        /// </summary>
        public string List_Runtimes => "List-Runtimes";

        /// <summary>
        /// <para><value>List-Sdks</value></para>
        /// </summary>
        public string List_Sdks => "List-Sdks";

        /// <summary>
        /// <para><value>Nupkg-FilePath</value></para>
        /// </summary>
        public string Nupkg_FilePath => "Nupkg-FilePath";

        /// <summary>
        /// <para><value>Migration-Name</value></para>
        /// </summary>
        public string Migration_Name => "Migration-Name";

        /// <summary>
        /// <para><value>Package-Source</value></para>
        /// </summary>
        public string Package_Source => "Package-Source";

        /// <summary>
        /// <para><value>Project-FilePath</value></para>
        /// </summary>
        public string Project_FilePath => "Project-FilePath";

        /// <summary>
        /// <para><value>ToolName</value></para>
        /// </summary>
        public string ToolName => "ToolName";

        /// <summary>
        /// <para><value>Version</value></para>
        /// </summary>
        public string Version => "Version";
    }
}
