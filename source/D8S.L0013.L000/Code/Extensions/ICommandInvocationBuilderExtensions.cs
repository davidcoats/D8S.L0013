using System;


namespace D8S.L0013.L000.Extensions
{
    public static class ICommandInvocationBuilderExtensions
    {
        public static T Add_Argument<T>(this T builder,
            CommandInvocationArgument argument)
            where T : ICommandArgumentsBuilder
        {
            Instances.CommandInvocationOperator.Add_Argument(
                builder,
                argument);

            return builder;
        }

        public static T Add_Argument<T>(this T builder,
            string argumentName,
            IArgument argument)
            where T : ICommandArgumentsBuilder
        {
            Instances.CommandInvocationOperator.Add_Argument(
                builder,
                argumentName,
                argument);

            return builder;
        }

        public static T Add_SubCommandArgument<T>(this T builder,
            SubCommandArgument subCommandArgument)
            where T : ICommandArgumentsBuilder
        {
            Instances.CommandInvocationOperator.Add_Argument_SubCommand(
                builder,
                subCommandArgument);

            return builder;
        }

        public static T Add_ValueArgument<T>(this T builder,
            string argumentName,
            ValueArgument valueArgument)
            where T : ICommandArgumentsBuilder
        {
            Instances.CommandInvocationOperator.Add_Argument(
                builder,
                argumentName,
                valueArgument);

            return builder;
        }

        public static T Add_VerbArgument<T>(this T builder,
            VerbArgument verbArgument)
            where T : ICommandArgumentsBuilder
        {
            Instances.CommandInvocationOperator.Add_Argument_Verb(
                builder,
                verbArgument);

            return builder;
        }

        public static T Add_Help_Argument<T>(this T builder)
            where T : ICommandArgumentsBuilder
            => builder.Add_Argument(
                Instances.CommandInvocationArguments.help);

        public static T Set_Command<T>(this T builder,
            string command)
            where T : ICommandInvocationBuilder
        {
            Instances.CommandInvocationOperator.Set_Command(
                builder,
                command);

            return builder;
        }

        public static T Set_WorkingDirectoryPath<T>(this T builder,
            string workingDirectoryPath)
            where T : ICommandInvocationBuilder
        {
            Instances.CommandInvocationOperator.Set_WorkingDirectoryPath(
                builder,
                workingDirectoryPath);

            return builder;
        }

        public static CommandInvocation Build_CommandInvocation(this ICommandInvocationBuilder builder)
            => Instances.CommandInvocationOperator.Build_CommandInvocation(builder);

        public static CommandInvocation Build(this ICommandInvocationBuilder builder)
            => builder.Build_CommandInvocation();
    }
}
