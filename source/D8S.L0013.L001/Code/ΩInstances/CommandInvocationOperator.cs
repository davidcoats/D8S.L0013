using System;


namespace D8S.L0013.L001
{
    public class CommandInvocationOperator : ICommandInvocationOperator
    {
        #region Infrastructure

        public static ICommandInvocationOperator Instance { get; } = new CommandInvocationOperator();


        private CommandInvocationOperator()
        {
        }

        #endregion
    }
}
