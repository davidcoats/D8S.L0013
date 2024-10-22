using System;


namespace D8S.L0013.L000
{
    public static class Instances
    {
        public static IArgumentNames ArgumentNames => L000.ArgumentNames.Instance;
        public static IArguments Arguments => L000.Arguments.Instance;
        public static ICommandInvocationArguments CommandInvocationArguments => L000.CommandInvocationArguments.Instance;
        public static ICommandInvocationOperator CommandInvocationOperator => L000.CommandInvocationOperator.Instance;
        public static IOptionNames OptionNames => L000.OptionNames.Instance;
        public static R5T.L0066.IStringOperator StringOperator => R5T.L0066.StringOperator.Instance;
        public static R5T.L0066.IStrings Strings => R5T.L0066.Strings.Instance;
        public static R5T.L0066.ITextOperator TextOperator => R5T.L0066.TextOperator.Instance;
    }
}