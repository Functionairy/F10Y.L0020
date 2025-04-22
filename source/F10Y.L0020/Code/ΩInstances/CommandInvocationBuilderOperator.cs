using System;


namespace F10Y.L0020
{
    public class CommandInvocationBuilderOperator : ICommandInvocationBuilderOperator
    {
        #region Infrastructure

        public static ICommandInvocationBuilderOperator Instance { get; } = new CommandInvocationBuilderOperator();


        private CommandInvocationBuilderOperator()
        {
        }

        #endregion
    }
}
