using System;


namespace F10Y.L0020.Construction
{
    public static class Instances
    {
        public static ICommandInvocationBuilderOperator CommandInvocationBuilderOperator => L0020.CommandInvocationBuilderOperator.Instance;
        public static ICommandInvocationOperator CommandInvocationOperator => L0020.CommandInvocationOperator.Instance;
        public static ICommandLineOperator CommandLineOperator => L0020.CommandLineOperator.Instance;
        public static ICommandResultOperator CommandResultOperator => L0020.CommandResultOperator.Instance;
        public static L0000.IConsoleOperator ConsoleOperator => L0000.ConsoleOperator.Instance;
        public static L0000.IProcessOperator ProcessOperator => L0000.ProcessOperator.Instance;
    }
}