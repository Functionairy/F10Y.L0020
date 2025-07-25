using System;


namespace F10Y.L0020
{
    public class NamedArgument : INamedArgument
    {
        public string Name { get; set; }

        public IArgument Argument { get; set; }
    }
}
