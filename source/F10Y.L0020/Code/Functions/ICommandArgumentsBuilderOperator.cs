using System;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandArgumentsBuilderOperator
    {
        void Add_Argument(
            ICommandArgumentsBuilder builder,
            string argument)
            => this.Add_Argument(
                builder,
                Instances.ArgumentNames.DEFAULT,
                Instances.ArgumentOperator.Value(argument));

        void Add_Argument(
            ICommandArgumentsBuilder builder,
            string argumentName,
            IArgument argument)
            => builder.Arguments_ByArgumentName.Add(
                argumentName,
                argument);

        void Add_Argument(
            ICommandArgumentsBuilder builder,
            INamedArgument argument)
            => this.Add_Argument(
                builder,
                argument.Name,
                argument.Argument);

        void Add_Argument_FilePath(
            ICommandArgumentsBuilder builder,
            string filePath)
            => this.Add_Argument(
                builder,
                Instances.ArgumentNames.FILE_PATH,
                Instances.ArgumentOperator.Path(filePath));
    }
}
