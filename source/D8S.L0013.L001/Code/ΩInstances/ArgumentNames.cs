using System;


namespace D8S.L0013.L001
{
    public class ArgumentNames : IArgumentNames
    {
        #region Infrastructure

        public static IArgumentNames Instance { get; } = new ArgumentNames();


        private ArgumentNames()
        {
        }

        #endregion
    }
}
