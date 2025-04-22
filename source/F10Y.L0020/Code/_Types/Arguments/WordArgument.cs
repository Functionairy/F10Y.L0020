using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A simple word argument.
    /// <para>
    /// This is useful as a base class for other more conceptually-specific, but still just-a-word, argument types.
    /// </para>
    /// </summary>
    [DataTypeMarker]
    public class WordArgument : IArgument
    {
        public string Value { get; set; }


        public WordArgument()
        {
        }

        public WordArgument(string value)
        {
            this.Value = value;
        }

        public string Get_ArgumentText()
            => this.Value;
    }
}
