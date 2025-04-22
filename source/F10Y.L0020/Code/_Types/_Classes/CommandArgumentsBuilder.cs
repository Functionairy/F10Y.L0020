using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A builder for command arguments.
    /// </summary>
    [UtilityTypeMarker]
    public class CommandArgumentsBuilder : ICommandArgumentsBuilder
    {
        /// <summary>
        /// Arguments by name.
        /// </summary>
        /// <remarks>
        /// The argument name is <strong>not</strong> output to the command line, but instead serves to identify the argument.
        /// </remarks>
        public IDictionary<string, IArgument> Arguments_ByArgumentName { get; }


        public CommandArgumentsBuilder()
            : this(new Dictionary<string, IArgument>())
        {
        }

        public CommandArgumentsBuilder(IDictionary<string, IArgument> arguments_ByArgumentName)
        {
            this.Arguments_ByArgumentName = arguments_ByArgumentName;
        }
    }
}
