using System;


namespace D8S.L0013.L001
{
    public class DotnetToolNames : IDotnetToolNames
    {
        #region Infrastructure

        public static IDotnetToolNames Instance { get; } = new DotnetToolNames();


        private DotnetToolNames()
        {
        }

        #endregion
    }
}
