using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A value.
    /// </summary>
    [DataTypeMarker]
    public class ValueArgument : WordArgument
    {
        public ValueArgument()
            : base()
        {
        }

        public ValueArgument(string value)
            : base(value)
        {
        }
    }
}
