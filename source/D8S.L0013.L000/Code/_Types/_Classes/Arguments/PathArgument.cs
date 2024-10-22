using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A path-based argument.
    /// <para>
    /// This is useful as a base class for other more conceptually-specific, but still just-a-word, argument types.
    /// </para>
    /// </summary>
    [DataTypeMarker]
    public class PathArgument : IArgument
    {
        public string Value { get; set; }


        public string Get_ArgumentText()
        {
            // A path should be enquoted.
            var output = Instances.StringOperator.Ensure_Enquoted(this.Value);
            return output;
        }
    }
}
