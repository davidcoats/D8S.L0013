using System;
using System.IO;
using System.Linq;

using R5T.T0132;


namespace D8S.L0013.L000
{
    [FunctionalityMarker]
    public partial interface ICommandInvocationOperator : IFunctionalityMarker
    {
        public void Add_Argument(
            ICommandArgumentsBuilder builder,
            CommandInvocationArgument argument)
            => builder.Arguments_ByArgumentName.Add(
                argument.ArgumentName,
                argument.Argument);

        public void Add_Argument(
            ICommandArgumentsBuilder builder,
            string argumentName,
            IArgument argument)
            => builder.Arguments_ByArgumentName.Add(
                argumentName,
                argument);

        public void Add_Argument_SubCommand(
            ICommandArgumentsBuilder builder,
            SubCommandArgument subCommandArgument)
            => builder.Arguments_ByArgumentName.Add(
                Instances.ArgumentNames.SubCommand,
                subCommandArgument);

        public void Add_Argument_Verb(
            ICommandArgumentsBuilder builder,
            VerbArgument verbArgument)
            => builder.Arguments_ByArgumentName.Add(
                Instances.ArgumentNames.Verb,
                verbArgument);

        /// <summary>
        /// Quality-of-life overload for <see cref="Set_Command(ICommandInvocationBuilder, string)"/>.
        /// </summary>
        public void Add_Command(
            ICommandInvocationBuilder builder,
            string command)
            => this.Set_Command(
                builder,
                command);

        public void Add_Argument_FilePath(
            ICommandArgumentsBuilder builder,
            string filePath)
        {
            var pathArgument = this.Get_PathArgument(filePath);

            this.Add_Argument(
                builder,
                Instances.ArgumentNames.FilePath,
                pathArgument);
        }

        public CommandInvocation Build_CommandInvocation(ICommandInvocationBuilder commandInvocationBuilder)
        {
            var command = commandInvocationBuilder.Command;

            var argumentTexts = commandInvocationBuilder.Arguments_ByArgumentName
                .Select(pair => pair.Value.Get_ArgumentText())
                ;

            var argument = Instances.StringOperator.Join(
                Instances.Strings.Space,
                argumentTexts);

            var output = new CommandInvocation
            {
                Argument = argument,
                Command = command,
                WorkingDirectoryPath = commandInvocationBuilder.WorkingDirectoryPath
            };

            return output;
        }

        public OptionArgument_Long Get_Option_Long(
            string flag,
            string value)
            => new OptionArgument_Long()
            {
                Flag = flag,
                Value = value
            };

        public OptionFlagArgument_Long Get_OptionFlag_Long(string value)
            => new OptionFlagArgument_Long()
            {
                Value = value
            };

        public OptionFlagArgument_Short Get_OptionFlag_Short(string value)
            => new OptionFlagArgument_Short()
            {
                Value = value
            };

        public PathArgument Get_PathArgument(string value)
            => new PathArgument
            {
                Value = value
            };

        public SubCommandArgument Get_Subcommand(string value)
            => new SubCommandArgument
            {
                Value = value
            };

        public ValueArgument Get_Value(string value)
            => new ValueArgument
            {
                Value = value
            };

        public VerbArgument Get_Verb(string value)
            => new VerbArgument
            {
                Value = value
            };

        /// <summary>
        /// Quality-of-life overload for <see cref="To_Text(CommandInvocation)"/>.
        /// </summary>
        public string Get_Text(CommandInvocation commandInvocation)
            => this.To_Text(commandInvocation);

        /// <summary>
        /// Prefixes a <inheritdoc cref="R5T.L0066.IStrings.Dash" path="descendant::description"/> to the flag name.
        /// </summary>
        public string Get_FlagText_Short(string flagName)
        {
            var output = $"{Instances.Strings.Dash}{flagName}";
            return output;
        }

        /// <summary>
        /// Prefixes a <inheritdoc cref="R5T.L0066.IStrings.DoubleDash" path="descendant::description"/> to the flag name.
        /// </summary>
        public string Get_FlagText_Long(string flagName)
        {
            var output = $"{Instances.Strings.DoubleDash}{flagName}";
            return output;
        }

        public CommandInvocationBuilder New_Command()
            => new CommandInvocationBuilder();

        public void Set_Command(
            ICommandInvocationBuilder builder,
            string command)
            => builder.Command = command;

        public void Set_ExecutableFilePath(
            ICommandInvocationBuilder builder,
            string executableFilePath)
            => builder.Command = executableFilePath;

        public void Set_WorkingDirectoryPath(
            ICommandInvocationBuilder builder,
            string workingDirectoryPath)
            => builder.WorkingDirectoryPath = workingDirectoryPath;

        public string To_Text(CommandInvocation commandInvocation)
        {
            var workingDirectoryPath_IsNullOrEmpty = Instances.StringOperator.Is_NullOrEmpty(commandInvocation.WorkingDirectoryPath);
            var workingDirectory_Token = workingDirectoryPath_IsNullOrEmpty
                ? "<unspecified>"
                : commandInvocation.WorkingDirectoryPath
                ;

            var output = $"{commandInvocation.Command}{Instances.Strings.Space}{commandInvocation.Argument}\nWorking directory:\n\t{workingDirectory_Token}";
            return output;
        }

        public void Write_To_Synchronous(
            TextWriter writer,
            CommandInvocation commandInvocation)
        {
            var text = this.To_Text(commandInvocation);

            writer.WriteLine(text);
        }
    }
}
