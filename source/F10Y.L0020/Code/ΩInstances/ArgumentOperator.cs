using System;


namespace F10Y.L0020
{
    public class ArgumentOperator : IArgumentOperator
    {
        #region Infrastructure

        public static IArgumentOperator Instance { get; } = new ArgumentOperator();


        private ArgumentOperator()
        {
        }

        #endregion
    }
}
