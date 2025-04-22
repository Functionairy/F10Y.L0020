using System;


namespace F10Y.L0020
{
    public static class ICommandArgumentsBuilderExtensions
    {
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
    }
}
