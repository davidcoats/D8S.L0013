using System;


namespace D8S.L0013.L000
{
    public class CommandInvocationArguments : ICommandInvocationArguments
    {
        #region Infrastructure

        public static ICommandInvocationArguments Instance { get; } = new CommandInvocationArguments();


        private CommandInvocationArguments()
        {
        }

        #endregion
    }
}
