using System;


namespace F10Y.L0020
{
    public class CommandArgumentsBuilderOperator : ICommandArgumentsBuilderOperator
    {
        #region Infrastructure

        public static ICommandArgumentsBuilderOperator Instance { get; } = new CommandArgumentsBuilderOperator();


        private CommandArgumentsBuilderOperator()
        {
        }

        #endregion
    }
}
