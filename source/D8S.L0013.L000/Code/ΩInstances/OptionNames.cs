using System;


namespace D8S.L0013.L000
{
    public class OptionNames : IOptionNames
    {
        #region Infrastructure

        public static IOptionNames Instance { get; } = new OptionNames();


        private OptionNames()
        {
        }

        #endregion
    }
}
