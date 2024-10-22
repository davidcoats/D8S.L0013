using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A simple word argument.
    /// <para>
    /// This is useful as a base class for other more conceptually-specific, but still just-a-word, argument types.
    /// </para>
    /// </summary>
    [DataTypeMarker]
    public class WordArgument : IArgument
    {
        public string Value { get; set; }


        public string Get_ArgumentText()
        {
            var output = this.Value;
            return output;
        }
    }
}
