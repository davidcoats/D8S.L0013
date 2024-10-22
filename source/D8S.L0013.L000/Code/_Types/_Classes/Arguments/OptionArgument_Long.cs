using System;

using R5T.T0142;


namespace D8S.L0013.L000
{
    /// <summary>
    /// A named flag (with a long name).
    /// </summary>
    [DataTypeMarker]
    public class OptionFlagArgument_Long : IArgument
    {
        public string Value { get; set; }


        public string Get_ArgumentText()
        {
            var output = Instances.CommandInvocationOperator.Get_FlagText_Long(
                this.Value);

            return output;
        }
    }
}
