using System;

using F10Y.T0002;


namespace F10Y.L0020.Base
{
    [FunctionsMarker]
    public partial interface ICommandInvocationOperator
    {
        CommandInvocation Build_CommandInvocation(ICommandInvocationBuilder commandInvocationBuilder)
            => Instances.CommandInvocationBuilderOperator.Build_CommandInvocation(commandInvocationBuilder);

        TCommandInvocationBuilder New<TCommandInvocationBuilder>()
            where TCommandInvocationBuilder : ICommandInvocationBuilder, new()
            => new TCommandInvocationBuilder();
    }
}
