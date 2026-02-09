using System;
using System.Collections.Generic;
using System.Diagnostics;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0020
{
    /// <summary>
    /// Functions to run commands on arguments that return a <see cref="CommandResult"/> instance to allow examining the execution of a command.
    /// </summary>
    [FunctionsMarker]
    public partial interface ICommandLineOperator :
        L0000.ICommandLineOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ICommandLineOperator _L0000 => L0000.CommandLineOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        CommandResult Run_Synchronous(
            string command,
            string arguments,
            string workingDirectory,
            DataReceivedEventHandler outputHandler,
            DataReceivedEventHandler errorHandler)
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var outputHandler_Aggregate = Instances.ProcessOperator.Get_DataReceivedEventHandler_Aggregate(
                outputHandler,
                Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator));

            var errorHandler_Aggregate = Instances.ProcessOperator.Get_DataReceivedEventHandler_Aggregate(
                errorHandler,
                Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator));

            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        command,
                        arguments,
                        workingDirectory,
                        outputHandler_Aggregate,
                        errorHandler_Aggregate);

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

        CommandResult Run_Synchronous(
            string command,
            string arguments,
            DataReceivedEventHandler outputHandler,
            DataReceivedEventHandler errorHandler)
            => this.Run_Synchronous(
                command,
                arguments,
                Instances.Values.WorkingDirectory_Default,
                outputHandler,
                errorHandler);

        new CommandResult Run_Synchronous(
            string command,
            string arguments,
            string workingDirectory)
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var outputHandler = Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator);
            var errorHandler = Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator);

            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        command,
                        arguments,
                        workingDirectory,
                        outputHandler,
                        errorHandler);

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

        CommandResult Run_Synchronous_WithConsoleOutput(
            string command,
            string arguments,
            string workingDirectory)
            => this.Run_Synchronous(
                command,
                arguments,
                workingDirectory,
                Instances.ProcessOperator.DataReceivedHandler_WriteToConsole,
                Instances.ProcessOperator.DataReceivedHandler_WriteToConsole);

        CommandResult Run_Synchronous_WithConsoleOutput(
            string command,
            string arguments)
            => this.Run_Synchronous_WithConsoleOutput(
                command,
                arguments,
                Instances.Values.WorkingDirectory_Default);

        CommandResult Run_Synchronous(
            string command,
            string arguments,
            string workingDirectory,
            Action<ProcessStartInfo> configure_ProcessStartInfo)
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var outputHandler = Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator);
            var errorHandler = Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator);

            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        command,
                        arguments,
                        workingDirectory,
                        outputHandler,
                        errorHandler,
                        configure_ProcessStartInfo);

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

        new CommandResult Run_Synchronous(
            string command,
            string arguments)
            => this.Run_Synchronous(
                command,
                arguments,
                Instances.Values.WorkingDirectory_Default);

        CommandResult Run_Synchronous(
            string command,
            string arguments,
            Action<ProcessStartInfo> configure_ProcessStartInfo)
            => this.Run_Synchronous(
                command,
                arguments,
                Instances.Values.WorkingDirectory_Default,
                configure_ProcessStartInfo);

        new CommandResult Run_Synchronous(string command)
            => this.Run_Synchronous(
                command,
                Instances.Values.EmptyCommandArguments);

        CommandResult Run_Synchronous(CommandInvocation commandInvocation)
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var outputHandler = Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator);
            var errorHandler = Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator);

            var exitCode = Instances.StopwatchOperator.Measure_Duration(
                () =>
                {
                    var exitCode = Instances.ProcessOperator.Run_Synchronous(
                        commandInvocation.Command,
                        commandInvocation.Arguments,
                        commandInvocation.WorkingDirectory,
                        outputHandler,
                        errorHandler);

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

        N001.CommandResult Run_Synchronous(CommandInvocation commandInvocation,
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
