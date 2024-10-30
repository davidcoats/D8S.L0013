using System;
using System.Diagnostics;

using R5T.T0132;

using D8S.L0013.L000;


namespace D8S.L0013.F001
{
    [FunctionalityMarker]
    public partial interface IProcessOperator : IFunctionalityMarker,
        L0002.L001.IProcessOperator
    {
        public CommandResult Run_Synchronous(
            string command,
            string commandArgument)
            => this.Run_Synchronous(
                command,
                commandArgument,
                Instances.Strings.Empty);

        public CommandResult Run_Synchronous(
            string command,
            string commandArgument,
            string workingDirectoryPath)
        {
            var receiveOutputHandler = this.Get_DataReceivedEventHandler_Default(out var outputLines);
            var receiveErrorHandler = this.Get_DataReceivedEventHandler_Default(out var errorLines);

            var result = this.Run_Synchronous(
                command,
                commandArgument,
                workingDirectoryPath,
                receiveOutputHandler,
                receiveErrorHandler);

            var output = new CommandResult(
                OutputLines: outputLines.ToArray(),
                ErrorLines: errorLines.ToArray(),
                ExitCode: result.ExitCode,
                Duration: result.Duration);

            return output;
        }

        public N001.CommandResult Run_Synchronous(
            string command,
            string commandArgument,
            DataReceivedEventHandler receiveOutputHandler,
            DataReceivedEventHandler receiveErrorHandler)
            => this.Run_Synchronous(
                command,
                commandArgument,
                Instances.Strings.Empty,
                receiveOutputHandler,
                receiveErrorHandler);

        public N001.CommandResult Run_Synchronous(
            string command,
            string commandArgument,
            string workingDirectoryPath,
            DataReceivedEventHandler receiveOutputHandler,
            DataReceivedEventHandler receiveErrorHandler)
        {
            var startInfo = this.Set_Command(
                Instances.ProcessStartInfos.Windowless,
                command,
                commandArgument);

            var workingDirectoryPath_IsNotNullOrEmpty = Instances.StringOperator.Is_NotNullOrEmpty(workingDirectoryPath);
            if (workingDirectoryPath_IsNotNullOrEmpty)
            {
                startInfo.WorkingDirectory = workingDirectoryPath;
            }

            var process = new Process()
            {
                StartInfo = startInfo,
            };

            process.OutputDataReceived += receiveOutputHandler;
            process.ErrorDataReceived += receiveErrorHandler;

            var duration = Instances.TimingOperator.Measure_Duration_OfAction(() =>
            {
                process.Start();
                process.BeginOutputReadLine(); // Must occur after start?
                process.BeginErrorReadLine(); // Must occur after start?

                process.WaitForExit();
            });

            process.OutputDataReceived -= receiveOutputHandler;
            process.ErrorDataReceived -= receiveErrorHandler;

            int exitCode = process.ExitCode; // Must get value before closing the process?

            process.Close();

            var output = new N001.CommandResult(
                ExitCode: exitCode,
                Duration: duration);

            return output;
        }

        public CommandResult Run_Synchronous(
            CommandInput input)
            => this.Run_Synchronous(
                input.Command,
                input.CommandArgument);

        public void Start(CommandInvocation commandInvocation)
        => this.Start(
            commandInvocation.Command,
            commandInvocation.Argument);
    }
}
