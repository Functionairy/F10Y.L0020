using System;


namespace F10Y.L0020.Extensions
{
    public static class ICommandArgumentsBuilderExtensions
    {
        public static void Add_Argument(this ICommandArgumentsBuilder builder,
            string argumentName,
            IArgument argument)
            => Instances.CommandArgumentsBuilderOperator.Add_Argument(
                builder,
                argumentName,
                argument);

        public static TCommandArgumentsBuilder Add_Argument<TCommandArgumentsBuilder>(this TCommandArgumentsBuilder builder,
            string argument)
            where TCommandArgumentsBuilder : ICommandArgumentsBuilder
        {
            Instances.CommandArgumentsBuilderOperator.Add_Argument(
                builder,
                argument);

            return builder;
        }

        public static TCommandArgumentsBuilder Add_Argument_FilePath<TCommandArgumentsBuilder>(this TCommandArgumentsBuilder builder,
            string filePath)
            where TCommandArgumentsBuilder : ICommandArgumentsBuilder
        {
            Instances.CommandArgumentsBuilderOperator.Add_Argument_FilePath(
                builder,
                filePath);

            return builder;
        }

        public static TCommandArgumentsBuilder Add_Argument<TCommandArgumentsBuilder>(this TCommandArgumentsBuilder builder,
            string argumentName,
            IArgument argument)
            where TCommandArgumentsBuilder : ICommandArgumentsBuilder
        {
            Instances.CommandArgumentsBuilderOperator.Add_Argument(
                builder,
                argumentName,
                argument);

            return builder;
        }

        public static TCommandArgumentsBuilder Add_Argument<TCommandArgumentsBuilder>(this TCommandArgumentsBuilder builder,
            INamedArgument argument)
            where TCommandArgumentsBuilder : ICommandArgumentsBuilder
        {
            Instances.CommandArgumentsBuilderOperator.Add_Argument(
                builder,
                argument);

            return builder;
        }
    }
}
