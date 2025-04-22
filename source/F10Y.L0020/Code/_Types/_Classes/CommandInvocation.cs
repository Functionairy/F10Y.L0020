using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    [DataTypeMarker]
    public class CommandInvocation
    {
        /// <summary>
        /// The directory in which the command should be invoked.
        /// </summary>
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// The command.
        /// <para><inheritdoc cref="Documentation.For_CommandInvocation.Command_Definition" path="/summary"/></para>
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// <inheritdoc cref="Documentation.For_CommandInvocation.Argument_Definition" path="/summary"/>
        /// </summary>
        public string Arguments { get; set; }
    }
}
