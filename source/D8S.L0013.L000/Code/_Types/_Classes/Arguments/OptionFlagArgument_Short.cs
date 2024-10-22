using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A named flag (with a short name).
    /// </summary>
    [DataTypeMarker]
    public class OptionFlagArgument_Short : IArgument
    {
        public string Value { get; set; }


        public string Get_ArgumentText()
        {
            var output = Instances.CommandInvocationOperator.Get_FlagText_Short(
                this.Value);

            return output;
        }
    }
}
