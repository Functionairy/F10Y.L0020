using System;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface IArgumentOperator
    {
        FlagArgument Flag(string flag)
            => new FlagArgument()
            {
                Flag = flag,
                Indicator = Instances.Strings.Dash
            };

        PathArgument Path(string path)
            => new PathArgument()
            {
                Value = path
            };

        ValueArgument Value(string value)
            => new ValueArgument()
            {
                Value = value
            };

        WordArgument Word(string word)
            => new WordArgument()
            {
                Value = word
            };
    }
}
