using System;
using System.Collections.Generic;
using System.Linq;
using F10Y.L0000.Extensions;
using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandInvocationOperator :
        Base.ICommandInvocationOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Base.ICommandInvocationOperator _Base => Base.CommandInvocationOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        public FlagArgument Create_FlagArgument(
            string indicator,
            string flag)
        {
            var output = new FlagArgument
            {
                Flag = flag,
                Indicator = indicator,
            };

            return output;
        }

        public WordArgument Create_WordArgument(string value)
            => new WordArgument(value);

        public IEnumerable<string> Describe_ToLines(CommandInvocation commandInvocation)
        {
            var lines_WithoutDescription = this.Describe_ToLines_WithoutDescription(commandInvocation);

            var output = Instances.EnumerableOperator.From("Command:")
                .Append_Many(lines_WithoutDescription
                    .Select(line => $"\t{line}")
                )
                ;

            return output;
        }

        public IEnumerable<string> Describe_ToLines_WithoutDescription(CommandInvocation commandInvocation)
        {
            var workingDirectory_Token = this.Get_TokenOrUnspecified(commandInvocation.WorkingDirectory);

            var command_Token = this.Get_TokenOrUnspecified(commandInvocation.Command);

            var argumentToken = this.Get_TokenOrUnspecified(commandInvocation.Arguments);

            var output = Instances.EnumerableOperator.Empty<string>()
                .Append($"{command_Token}{Instances.Strings.Space}{argumentToken}")
                .Append("Working directory:")
                .Append($"\t{workingDirectory_Token}")
                ;

            return output;
        }

        public string Describe_ToText(CommandInvocation commandInvocation)
        {
            var workingDirectory_Token = this.Get_TokenOrUnspecified(commandInvocation.WorkingDirectory);

            var command_Token = this.Get_TokenOrUnspecified(commandInvocation.Command);

            var argumentToken = this.Get_TokenOrUnspecified(commandInvocation.Arguments);

            var output = $"{command_Token}{Instances.Strings.Space}{argumentToken}\nWorking directory:\n\t{workingDirectory_Token}";
            return output;
        }

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

        public CommandInvocationBuilder New()
            => Instances.CommandInvocationBuilderOperator.New();
    }
}
