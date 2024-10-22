using System;


namespace D8S.L0013.L001
{
    public static class Instances
    {
        public static IArgumentNames ArgumentNames => L001.ArgumentNames.Instance;
        public static IArguments Arguments => L001.Arguments.Instance;
        public static ICommandInvocationArguments CommandInvocationArguments => L001.CommandInvocationArguments.Instance;
        public static ICommandInvocationOperator CommandInvocationOperator => L001.CommandInvocationOperator.Instance;
        public static ICommands Commands => L001.Commands.Instance;
        public static IDotnetToolNames DotnetToolNames => L001.DotnetToolNames.Instance;
        public static IOptionNames OptionNames => L001.OptionNames.Instance;
        public static ISubCommands SubCommands => L001.SubCommands.Instance;
        public static IVerbs Verbs => L001.Verbs.Instance;
    }
}