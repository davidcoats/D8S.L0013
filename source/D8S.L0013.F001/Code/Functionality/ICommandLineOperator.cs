using System;

using R5T.T0132;

using D8S.L0013.L000;


namespace D8S.L0013.F001
{
    [FunctionalityMarker]
    public partial interface ICommandLineOperator : IFunctionalityMarker,
        R5T.L0066.ICommandLineOperator
    {
        public CommandResult Run_Synchronous(CommandInvocation commandInvocation)
            => this.Run_Synchronous(
                commandInvocation.Command,
                commandInvocation.Argument,
                commandInvocation.WorkingDirectoryPath);

        public new CommandResult Run_Synchronous(
            string command,
            string argument)
            => Instances.ProcessOperator.Run_Synchronous(
                command,
                argument);

        public CommandResult Run_Synchronous(
            string command,
            string argument,
            string workingDirectoryPath)
            => Instances.ProcessOperator.Run_Synchronous(
                command,
                argument,
                workingDirectoryPath);
    }
}
