using System;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandInvocationBuilderOperator
    {
        public CommandInvocation Build_CommandInvocation(ICommandInvocationBuilder commandInvocationBuilder)
        {
            var argumentTexts = commandInvocationBuilder.Arguments_ByArgumentName
                .Select(pair => pair.Value.Get_ArgumentText())
                ;

            var argument = Instances.StringOperator.Join(
                Instances.Strings.Space,
                argumentTexts);

            var output = new CommandInvocation
            {
                Arguments = argument,
                Command = commandInvocationBuilder.Command,
                WorkingDirectory = commandInvocationBuilder.WorkingDirectory
            };

            return output;
        }

        public TCommandInvocationBuilder New<TCommandInvocationBuilder>()
            where TCommandInvocationBuilder : ICommandInvocationBuilder, new()
            => new TCommandInvocationBuilder();

        public CommandInvocationBuilder New()
            => this.New<CommandInvocationBuilder>();

        public void Set_Command(
            ICommandInvocationBuilder builder,
            string command)
            => builder.Command = command;
    }
}
