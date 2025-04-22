using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A subcommand.
    /// </summary>
    [DataTypeMarker]
    public class SubCommandArgument : WordArgument
    {
        public SubCommandArgument()
            : base()
        {
        }

        public SubCommandArgument(string value)
            : base(value)
        {
        }
    }
}
