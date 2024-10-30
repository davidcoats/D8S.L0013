using System;


namespace D8S.L0013.F001
{
    public class ProcessOperator : IProcessOperator
    {
        #region Infrastructure

        public static IProcessOperator Instance { get; } = new ProcessOperator();


        private ProcessOperator()
        {
        }

        #endregion
    }
}
