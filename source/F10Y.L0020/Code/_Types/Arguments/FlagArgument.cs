using System;

using F10Y.T0004;


namespace F10Y.L0020
{
    /// <summary>
    /// A named flag with its indicator.
    /// Example: -version
    /// </summary>
    [DataTypeMarker]
    public class FlagArgument : IArgument
    {
        /// <summary>
        /// The flag indicator (generally '-', dash).
        /// </summary>
        public string Indicator { get; set; }

        /// <summary>
        /// The flag value itself (example: version).
        /// </summary>
        public string Flag { get; set; }


        public string Get_ArgumentText()
            => Instances.CommandInvocationOperator.Get_FlagText(
                this.Indicator,
                this.Flag);
    }
}
