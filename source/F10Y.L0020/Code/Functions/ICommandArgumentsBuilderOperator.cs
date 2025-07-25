using System;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandArgumentsBuilderOperator
    {
        public void Add_Argument(
            ICommandArgumentsBuilder builder,
            string argumentName,
            IArgument argument)
            => builder.Arguments_ByArgumentName.Add(
                argumentName,
                argument);

        public void Add_Argument(
            ICommandArgumentsBuilder builder,
            INamedArgument argument)
            => this.Add_Argument(
                builder,
                argument.Name,
                argument.Argument);
    }
}
