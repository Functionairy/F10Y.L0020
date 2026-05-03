using System;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandInvocationBuilderOperator
    {
        CommandInvocation Build_CommandInvocation(ICommandInvocationBuilder commandInvocationBuilder)
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

        TCommandInvocationBuilder New<TCommandInvocationBuilder>()
            where TCommandInvocationBuilder : ICommandInvocationBuilder, new()
            => new TCommandInvocationBuilder();

        CommandInvocationBuilder New()
            => this.New<CommandInvocationBuilder>();

        /// <summary>
        /// Set the command (either executable file path, or executable name on the search path).
        /// </summary>
        void Set_Command(
            ICommandInvocationBuilder builder,
            string command)
            => builder.Command = command;
    }
}
