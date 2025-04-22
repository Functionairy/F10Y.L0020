using System;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandInvocationOperator
    {
        public CommandInvocation Build_CommandInvocation(ICommandInvocationBuilder commandInvocationBuilder)
            => Instances.CommandInvocationBuilderOperator.Build_CommandInvocation(commandInvocationBuilder);

        public WordArgument Create_WordArgument(string value)
            => new WordArgument(value);

        public string Get_FlagText(
            string indicator,
            string flag)
            => Instances.StringOperator.Concatenate(
                indicator,
                flag);

        public string Get_FlagValuePairText(
            string indicator,
            string flag,
            string separator,
            string value)
        {
            var flagText = this.Get_FlagText(
                indicator,
                flag);

            var output = Instances.StringOperator.Concatenate(
                flagText,
                separator,
                value);

            return output;
        }

        public string Get_TokenOrUnspecified(string token)
        {
            var is_NullOrEmpty = Instances.StringOperator.Is_NullOrEmpty(token);

            var output = is_NullOrEmpty
                ? "<unspecified>"
                : token
                ;

            return output;
        }

        public TCommandInvocationBuilder New<TCommandInvocationBuilder>()
            where TCommandInvocationBuilder : ICommandInvocationBuilder, new()
            => Instances.CommandInvocationOperator.New<TCommandInvocationBuilder>();

        public CommandInvocationBuilder New()
            => Instances.CommandInvocationBuilderOperator.New();

        public string To_Text(CommandInvocation commandInvocation)
        {
            var workingDirectory_Token = this.Get_TokenOrUnspecified(commandInvocation.WorkingDirectory);

            var command_Token = this.Get_TokenOrUnspecified(commandInvocation.Command);

            var argumentToken = this.Get_TokenOrUnspecified(commandInvocation.Arguments);

            var output = $"{command_Token}{Instances.Strings.Space}{argumentToken}\nWorking directory:\n\t{workingDirectory_Token}";
            return output;
        }
    }
}
