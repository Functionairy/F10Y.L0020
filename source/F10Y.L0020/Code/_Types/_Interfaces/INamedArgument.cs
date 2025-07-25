using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A command invocation argument.
    /// </summary>
    [DataTypeMarker]
    public interface INamedArgument
    {
        string Name { get; }
        public IArgument Argument { get; }
    }
}
