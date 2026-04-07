using System;
using System.Collections.Generic;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ITextOperator :
        L0000.ITextOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ITextOperator _L0000 => L0000.TextOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        IEnumerable<string> Get_Lines_Content(CommandResult commandResult)
            => Instances.CommandResultOperator.Describe(commandResult);
    }
}
