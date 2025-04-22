using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A named flag with its indicator.
    /// </summary>
    [DataTypeMarker]
    public class FlagArgument : IArgument
    {
        public string Indicator { get; set; }
        public string Flag { get; set; }


        public string Get_ArgumentText()
            => Instances.CommandInvocationOperator.Get_FlagText(
                this.Indicator,
                this.Flag);
    }
}
