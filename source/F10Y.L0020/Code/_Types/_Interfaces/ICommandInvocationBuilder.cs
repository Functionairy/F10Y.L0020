using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A builder ineterface for command invocations.
    /// </summary>
    [UtilityTypeMarker]
    public interface ICommandInvocationBuilder : ICommandArgumentsBuilder
    {
        /// <summary>
        /// The directory in which a command should be invoked.
        /// </summary>
        string WorkingDirectory { get; set; }

        /// <inheritdoc cref="Documentation.For_CommandInvocation.Command_Definition"/>
        string Command { get; set; }
    }
}
