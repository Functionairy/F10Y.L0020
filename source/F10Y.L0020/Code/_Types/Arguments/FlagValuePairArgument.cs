using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A named flag paired with a value.
    /// Includes both the flag indicator and flag-value separator token.
    /// </summary>
    [DataTypeMarker]
    public class FlagValuePairArgument : IArgument
    {
        public string Indicator { get; set; }
        public string Flag { get; set; }
        public string Separator { get; set; }
        public string Value { get; set; }


        public string Get_ArgumentText()
            => Instances.CommandInvocationOperator.Get_FlagValuePairText(
                this.Indicator,
                this.Flag,
                this.Separator,
                this.Value);
    }
}
