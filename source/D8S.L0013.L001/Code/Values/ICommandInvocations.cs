using System;

using R5T.T0131;

using D8S.L0013.L000;
using D8S.L0013.L000.Extensions;


namespace D8S.L0013.L001
{
    [ValuesMarker]
    public partial interface ICommandInvocations : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// <para><value><inheritdoc cref="ICommands.dotnet" path="descendant::value[1]"/> <inheritdoc cref="L000.ICommandInvocationArguments.help" path="descendant::argument[1]"/></value></para>
        /// </summary>
        public CommandInvocation dotnet_help =>
            //Instances.CommandInvocationOperator.New_Command()
            //    .Set_Command(
            //        Instances.Commands.dotnet)
            //    .Add_Argument(
            //        Instances.CommandInvocationArguments.help
            //        )
            //    .Build();
            //Instances.CommandInvocationOperator.Build_DotnetCommand(argumentsBuilder =>
            //    argumentsBuilder
            //        .Add_Argument(Instances.CommandInvocationArguments.help)
            //    );
            Instances.CommandInvocationOperator.New_DotnetCommand()
                //.Add_Argument(Instances.CommandInvocationArguments.help)
                .Add_Help_Argument()
                //.Add_List_Runtimes_Argument()
                .Build();

        public CommandInvocation Install_DotnetEF =>
            //Instances.CommandInvocationOperator.New_DotnetCommand()
            //    .Add_SubCommandArgument(
            //        Instances.CommandInvocationOperator.Get_Subcommand(
            //            Instances.SubCommands.tool
            //        )
            //    )
            Instances.CommandInvocationOperator.New_DotnetToolCommand()
                .Add_VerbArgument(
                    Instances.CommandInvocationOperator.Get_Verb(
                        Instances.Verbs.install
                    )
                )
                .Add_Argument(
                    Instances.ArgumentNames.Global,
                    Instances.CommandInvocationOperator.Get_OptionFlag_Long(
                        Instances.OptionNames.global
                    )
                )
                .Add_Argument(
                    Instances.ArgumentNames.ToolName,
                    Instances.CommandInvocationOperator.Get_Value(
                        Instances.DotnetToolNames.dotnet_ef
                    )
                )
                .Build()
                ;

        /// <summary>
        /// Assumes global.
        /// </summary>
        public CommandInvocation List_DotnetTools =>
            Instances.CommandInvocationOperator.New_DotnetToolCommand()
                .Add_VerbArgument(
                    Instances.CommandInvocationOperator.Get_Verb(
                        Instances.Verbs.list
                    )
                )
                .Add_Argument(
                    Instances.ArgumentNames.Global,
                    Instances.CommandInvocationOperator.Get_OptionFlag_Long(
                        Instances.OptionNames.global
                    )
                )
                .Build()
                ;

#pragma warning restore IDE1006 // Naming Styles
    }
}
