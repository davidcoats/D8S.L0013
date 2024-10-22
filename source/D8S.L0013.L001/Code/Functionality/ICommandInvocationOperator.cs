using System;

using R5T.T0132;

using D8S.L0013.L000;
using D8S.L0013.L000.Extensions;
using D8S.L0013.L001.Extensions;


namespace D8S.L0013.L001
{
    [FunctionalityMarker]
    public partial interface ICommandInvocationOperator : IFunctionalityMarker,
        L000.ICommandInvocationOperator
    {
        public CommandInvocation Build_DotnetCommand(Action<IDotnetCommandArgumentsBuilder> builderAction)
        {
            var dotnetCommandBuilder = this.New_Command()
                .Set_Command(Instances.Commands.dotnet)
                ;

            var dotnetArgumentsBuilder = new DotnetCommandArgumentsBuilder(dotnetCommandBuilder.Arguments_ByArgumentName);

            builderAction(dotnetArgumentsBuilder);

            var output = dotnetCommandBuilder.Build();
            return output;
        }

        public CommandInvocationArgument Get_ApiKeyArgument(string apiKey)
        {
            var output = new CommandInvocationArgument
            {
                Argument = new OptionArgument_Long
                {
                    Flag = Instances.OptionNames.api_key,
                    Value = apiKey,
                },
                ArgumentName = Instances.ArgumentNames.API_Key
            };

            return output;
        }

        public CommandInvocationArgument Get_NupgkFilePathArgument(string nupkgFilePath)
        {
            var output = new CommandInvocationArgument
            {
                Argument = new PathArgument
                {
                    Value = nupkgFilePath,
                },
                ArgumentName = Instances.ArgumentNames.Nupkg_FilePath
            };

            return output;
        }

        public CommandInvocationArgument Get_PackageSourceArgument(string packageSourceUrl)
        {
            var output = new CommandInvocationArgument
            {
                Argument = new OptionArgument_Long
                {
                    Flag = Instances.OptionNames.source,
                    Value = packageSourceUrl,
                },
                ArgumentName = Instances.ArgumentNames.Package_Source
            };

            return output;
        }

        public CommandInvocationArgument Get_ProjectFilePathArgument(string projectFilePath)
        {
            var output = new CommandInvocationArgument
            {
                Argument = new PathArgument
                {
                    Value = projectFilePath,
                },
                ArgumentName = Instances.ArgumentNames.Project_FilePath
            };

            return output;
        }

        public DotnetCommandInvocationBuilder New_DotnetCommand(string dotnetCommand)
            => new DotnetCommandInvocationBuilder()
                .Set_Command(dotnetCommand)
                ;

        /// <summary>
        /// Uses <see cref="ICommands.dotnet"/>.
        /// </summary>
        public DotnetCommandInvocationBuilder New_DotnetCommand()
            => this.New_DotnetCommand(
                Instances.Commands.dotnet);

        public DotnetNugetCommandInvocationBuilder New_DotnetNugetCommand()
            => new DotnetNugetCommandInvocationBuilder()
                .Set_Command(Instances.Commands.dotnet)
                .Add_SubCommandArgument(Instances.Arguments.nuget)
                ;

        public DotnetToolCommandInvocationBuilder New_DotnetToolCommand()
            => new DotnetToolCommandInvocationBuilder()
                .Set_Command(Instances.Commands.dotnet)
                .Add_SubCommandArgument(Instances.Arguments.tool)
                ;

        public CommandInvocation Get_DotnetNugetPushCommand(
            string nupkgFilePath,
            string nugetApiKey,
            string packageSourceUrl)
        {
            var output = this.New_DotnetNugetCommand()
                .Add_VerbArgument(Instances.Arguments.push)
                .Add_NupkgFilePath_Argument(nupkgFilePath)
                .Add_ApiKey_Argument(nugetApiKey)
                .Add_PackageSource_Argument(packageSourceUrl)
                .Build();

            return output;
        }

        public CommandInvocation Get_DotnetPackCommand(
            string projectFilePath)
        {
            var output = this.New_DotnetCommand()
                .Add_VerbArgument(Instances.Arguments.pack)
                .Add_ProjectFilePath_Argument(projectFilePath)
                .Build();

            return output;
        }

        public CommandInvocation Get_Uninstall_DotnetTool_Command(
            string dotnetToolName)
        {
            var output = Instances.CommandInvocationOperator.New_DotnetToolCommand()
                .Add_VerbArgument(
                    this.Get_Verb(
                        Instances.Verbs.uninstall
                    )
                )
                .Add_ValueArgument(
                    Instances.ArgumentNames.ToolName,
                    this.Get_Value(dotnetToolName)
                )
                .Add_Argument(
                    Instances.ArgumentNames.Global,
                    this.Get_OptionFlag_Long(
                        Instances.OptionNames.global
                    )
                )
                .Build()
                ;

            return output;
        }
    }
}
