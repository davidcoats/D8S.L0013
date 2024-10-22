using System;

using R5T.T0131;


namespace D8S.L0013.L000
{
    [ValuesMarker]
    public partial interface IArgumentNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>Help</value></para>
        /// </summary>
        public string Help => "Help";

        /// <summary>
        /// <para><value>SubCommand</value></para>
        /// </summary>
        public string SubCommand => "SubCommand";

        /// <summary>
        /// <para><value>Verb</value></para>
        /// </summary>
        public string Verb => "Verb";
    }
}
