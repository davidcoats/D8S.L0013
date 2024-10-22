using System;

using R5T.T0131;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface IVerbs : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value>add</value></para>
        /// </summary>
        public string add => "add";

        /// <summary>
        /// <para><value>install</value></para>
        /// </summary>
        public string install => "install";

        /// <summary>
        /// <para><value>list</value></para>
        /// </summary>
        public string list => "list";

        /// <summary>
        /// <para><value>pack</value></para>
        /// </summary>
        public string pack => "pack";

        /// <summary>
        /// <para><value>push</value></para>
        /// </summary>
        public string push => "push";

        /// <summary>
        /// <para><value>uninstall</value></para>
        /// </summary>
        public string uninstall => "uninstall";

#pragma warning restore IDE1006 // Naming Styles
    }
}
