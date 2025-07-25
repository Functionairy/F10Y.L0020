using System;


namespace F10Y.L0020.Extensions
{
    public static class CommandResultExtensions
    {
        public static bool Is_Success(this CommandResult commandResult)
        {
            var output = Instances.CommandResultOperator.Is_Success(commandResult);
            return output;
        }
    }
}
