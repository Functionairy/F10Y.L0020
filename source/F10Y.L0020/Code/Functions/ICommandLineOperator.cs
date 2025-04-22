using System;
using System.Collections.Generic;
using System.Diagnostics;

using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandLineOperator :
        L0000.ICommandLineOperator
    {
        public new CommandResult Run_Synchronous(
            string command,
            string arguments,
            string workingDirectory)
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        command,
                        arguments,
                        workingDirectory,
                        Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator),
                        Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator));

                    return exitCode;
                },
                out var duration);

            var output = Instances.CommandResultOperator.Get_From(
                outputLines_Accumulator.ToArray(),
                errorLines_Accumulator.ToArray(),
                exitCode,
                duration);

            return output;
        }

        public new CommandResult Run_Synchronous(
            string command,
            string arguments)
            => this.Run_Synchronous(
                command,
                arguments,
                Instances.Values.WorkingDirectory_Default);

        public CommandResult Run_Synchronous(CommandInvocation commandInvocation)
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        commandInvocation.Command,
                        commandInvocation.Arguments,
                        commandInvocation.WorkingDirectory,
                        Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator),
                        Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator));

                    return exitCode;
                },
                out var duration);

            var output = Instances.CommandResultOperator.Get_From(
                outputLines_Accumulator.ToArray(),
                errorLines_Accumulator.ToArray(),
                exitCode,
                duration);

            return output;
        }

        public N001.CommandResult Run_Synchronous(CommandInvocation commandInvocation,
            DataReceivedEventHandler output_Handler)
        {
            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        commandInvocation.Command,
                        commandInvocation.Arguments,
                        commandInvocation.WorkingDirectory,
                        output_Handler);

                    return exitCode;
                },
                out var duration);

            var output = Instances.CommandResultOperator.Get_From(
                exitCode,
                duration);

            return output;
        }
    }
}
