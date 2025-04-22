using System;
using System.Threading.Tasks;


namespace F10Y.L0020.Construction
{
    class Program
    {
        static async Task Main()
        {
            await Program.Demonstrations_();
        }

        static async Task Demonstrations_()
        {
            await Program.Demonstrations_CommandInvocation();
        }

        static async Task Demonstrations_CommandInvocation()
        {
            //await CommandInvocationDemonstrations.Instance.Where_CommandInvocation_Simple();
            await CommandInvocationDemonstrations.Instance.Where_Simple();
        }
    }
}