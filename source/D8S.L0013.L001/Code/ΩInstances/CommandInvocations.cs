using System;


namespace D8S.L0013.L001
{
    public class CommandInvocations : ICommandInvocations
    {
        #region Infrastructure

        public static ICommandInvocations Instance { get; } = new CommandInvocations();


        private CommandInvocations()
        {
        }

        #endregion
    }
}
