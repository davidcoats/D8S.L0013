using System;

using D8S.L0013.L000.Extensions;


namespace D8S.L0013.L001.Extensions
{
    public static class ICommandArgumentBuilderExtensions
    {
        public static T Add_ApiKey_Argument<T>(this T builder,
            string apiKey)
            where T : IDotnetNugetCommandArgumentsBuilder
            => builder.Add_Argument(
                Instances.CommandInvocationOperator.Get_ApiKeyArgument(apiKey));

        public static T Add_List_Runtimes_Argument<T>(this T builder)
            where T : IDotnetCommandArgumentsBuilder
            => builder.Add_Argument(
                Instances.CommandInvocationArguments.list_runtimes);

        public static T Add_NupkgFilePath_Argument<T>(this T builder,
            string nupkgFilePath)
            where T : IDotnetNugetCommandArgumentsBuilder
            => builder.Add_Argument(
                Instances.CommandInvocationOperator.Get_NupgkFilePathArgument(nupkgFilePath));

        public static T Add_ProjectFilePath_Argument<T>(this T builder,
            string projectFilePath)
            where T : IDotnetCommandArgumentsBuilder
            => builder.Add_Argument(
                Instances.CommandInvocationOperator.Get_ProjectFilePathArgument(projectFilePath));

        public static T Add_PackageSource_Argument<T>(this T builder,
            string packageSourceUrl)
            where T : IDotnetNugetCommandArgumentsBuilder
            => builder.Add_Argument(
                Instances.CommandInvocationOperator.Get_PackageSourceArgument(packageSourceUrl));
    }
}
