using System;


namespace F10Y.L0020.Construction
{
    public class CommandInvocationDemonstrations : ICommandInvocationDemonstrations
    {
        #region Infrastructure

        public static ICommandInvocationDemonstrations Instance { get; } = new CommandInvocationDemonstrations();


        private CommandInvocationDemonstrations()
        {
        }

        #endregion
    }
}
