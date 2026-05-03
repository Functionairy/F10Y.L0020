using System;


namespace F10Y.L0020
{
    public static class Instances
    {
        public static IArgumentNames ArgumentNames => L0020.ArgumentNames.Instance;
        public static IArgumentOperator ArgumentOperator => L0020.ArgumentOperator.Instance;
        public static L0000.IBooleanOperator BooleanOperator => L0000.BooleanOperator.Instance;
        public static F10Y.L0000.ICharacters Characters => F10Y.L0000.Characters.Instance;
        public static ICommandArgumentsBuilderOperator CommandArgumentsBuilderOperator => L0020.CommandArgumentsBuilderOperator.Instance;
        public static ICommandInvocationBuilderOperator CommandInvocationBuilderOperator => L0020.CommandInvocationBuilderOperator.Instance;
        public static ICommandInvocationOperator CommandInvocationOperator => L0020.CommandInvocationOperator.Instance;
        public static ICommandResultOperator CommandResultOperator => L0020.CommandResultOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static L0000.IExitCodeOperator ExitCodeOperator => L0000.ExitCodeOperator.Instance;
        public static L0000.IFileOperator FileOperator => L0000.FileOperator.Instance;
        public static L0000.IProcessOperator ProcessOperator => L0000.ProcessOperator.Instance;
        public static L0000.IStringOperator StringOperator => L0000.StringOperator.Instance;
        public static L0000.IStrings Strings => L0000.Strings.Instance;
        public static L0000.IStopwatchOperator StopwatchOperator => L0000.StopwatchOperator.Instance;
        public static L0000.ITextWriterOperator TextWriterOperator => L0000.TextWriterOperator.Instance;
        public static L0000.IValues Values => L0000.Values.Instance;
    }
}