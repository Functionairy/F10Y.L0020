using System;


namespace F10Y.L0020.Extensions
{
    public static class ICommandInvocationBuilderExtensions
    {
        public static CommandInvocation Build(this ICommandInvocationBuilder builder)
            => Instances.CommandInvocationBuilderOperator.Build_CommandInvocation(builder);
    
        /// <inheritdoc cref="ICommandInvocationBuilderOperator.Set_Command(ICommandInvocationBuilder, string)"/>
        public static TCommandInvocationBuilder Set_Command<TCommandInvocationBuilder>(this TCommandInvocationBuilder builder,
            string command)
            where TCommandInvocationBuilder : ICommandInvocationBuilder
        {
            Instances.CommandInvocationBuilderOperator.Set_Command(
                builder,
                command);

            return builder;
        }
    }
}
