using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A path-based argument.
    /// <para>
    /// This is useful as a base class for other more conceptually-specific, but still just-a-word, argument types.
    /// </para>
    /// </summary>
    [DataTypeMarker]
    public class PathArgument : IArgument
    {
        public string Value { get; set; }


        public string Get_ArgumentText()
            => Instances.StringOperator.Ensure_Enquoted(this.Value);
    }
}
