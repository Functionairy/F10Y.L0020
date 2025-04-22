using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A builder for command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public class CommandInvocationBuilder : CommandArgumentsBuilder, ICommandInvocationBuilder
    {
        public string WorkingDirectory { get; set; }

        public string Command { get; set; }


        public CommandInvocationBuilder()
            : base()
        {
        }

        public CommandInvocationBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
            : base(arguments_ByArgumentName)
        {
        }
    }
}
