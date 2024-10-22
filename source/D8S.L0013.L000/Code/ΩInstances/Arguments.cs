using System;


namespace D8S.L0013.L000
{
    public class Arguments : IArguments
    {
        #region Infrastructure

        public static IArguments Instance { get; } = new Arguments();


        private Arguments()
        {
        }

        #endregion
    }
}
