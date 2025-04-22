using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A verb.
    /// </summary>
    [DataTypeMarker]
    public class VerbArgument : WordArgument
    {
        public VerbArgument()
            : base()
        {
        }

        public VerbArgument(string value)
            : base(value)
        {
        }
    }
}
