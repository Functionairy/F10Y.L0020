using System;


namespace F10Y.L0020
{
    public class CommandResultOperator : ICommandResultOperator
    {
        #region Infrastructure

        public static ICommandResultOperator Instance { get; } = new CommandResultOperator();


        private CommandResultOperator()
        {
        }

        #endregion
    }
}
