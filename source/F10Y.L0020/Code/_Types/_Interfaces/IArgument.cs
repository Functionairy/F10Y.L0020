using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A command invocation argument.
    /// </summary>
    [DataTypeMarker, UtilityTypeMarker]
    public interface IArgument
    {
        /// <summary>
        /// Gets the text representation of the argument for use at the command line.
        /// </summary>
        string Get_ArgumentText();
    }
}
