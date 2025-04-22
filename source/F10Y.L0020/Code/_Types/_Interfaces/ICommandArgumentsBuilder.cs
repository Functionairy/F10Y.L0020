using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A builder interface for command arguments.
    /// </summary>
    [UtilityTypeMarker]
    public interface ICommandArgumentsBuilder
    {
        IDictionary<string, IArgument> Arguments_ByArgumentName { get; }
    }
}
