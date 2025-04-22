using System;


namespace F10Y.L0020
{
    public class CommandInvocationOperator : ICommandInvocationOperator
    {
        #region Infrastructure

        public static ICommandInvocationOperator Instance { get; } = new CommandInvocationOperator();


        private CommandInvocationOperator()
        {
        }

        #endregion
    }
}
