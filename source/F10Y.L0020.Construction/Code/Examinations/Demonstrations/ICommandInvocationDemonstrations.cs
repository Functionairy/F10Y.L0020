using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using F10Y.T0006;

using F10Y.L0020.Extensions;


namespace F10Y.L0020.Construction
{
    [DemonstrationsMarker]
    public partial interface ICommandInvocationDemonstrations
    {
        /// <summary>
        /// Run the where command, fluently.
        /// </summary>
        public Task Where_CommandInvocation_Fluent()
        {
            var commandInvocation = Instances.CommandInvocationOperator.New()
                .Set_Command("where")
                .Add_Argument(
                    "pattern",
                    new WordArgument("ipconfig"))
                .Build()
                ;

            var commandResult = Instances.CommandLineOperator.Run_Synchronous(commandInvocation);

            Instances.CommandResultOperator.Describe_ToConsole_Synchronous(commandResult);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Run the where command, simply.
        /// </summary>
        public Task Where_CommandInvocation_Simple()
        {
            //var commandInvocationBuilder = new CommandInvocationBuilder()
            //{
            //    //WorkingDirectory = 
            //    Command = "where",
            //};

            var commandInvocationBuilder = new CommandInvocationBuilder
            {
                Command = "where"
            };

            commandInvocationBuilder.Arguments_ByArgumentName.Add(
                "pattern",
                new WordArgument("ipconfig"));

            var commandInvocation = Instances.CommandInvocationOperator.Build_CommandInvocation(commandInvocationBuilder);

            Instances.CommandLineOperator.Run_Synchronous(
                commandInvocation.Command,
                commandInvocation.Arguments,
                commandInvocation.WorkingDirectory);

            return Task.CompletedTask;
        }

        public Task Where_Simple_Clean()
        {
            var commandResult = Instances.CommandLineOperator.Run_Synchronous(
                "where",
                "ipconfig",
                "");

            Instances.ConsoleOperator.Write_Line($"{commandResult.ExitCode}: exit code");
            Instances.ConsoleOperator.Write_Line($"{commandResult.Duration}: duration");
            Instances.ConsoleOperator.Write_Line("Output:");
            Instances.ConsoleOperator.Write_Lines(commandResult.OutputLines);
            Instances.ConsoleOperator.Write_Line("Error:");
            Instances.ConsoleOperator.Write_Lines(commandResult.ErrorLines);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Run the where command, simply.
        /// </summary>
        /// <returns></returns>
        public Task Where_Simple()
        {
            var outputLines_Accumulator = new List<string>();
            var errorLines_Accumulator = new List<string>();

            var exitCode = Instances.ProcessOperator.Run_Synchronous(
                "where",
                "ipconfig",
                "",
                Instances.ProcessOperator.Get_DataReceivedEventHandler(outputLines_Accumulator),
                Instances.ProcessOperator.Get_DataReceivedEventHandler(errorLines_Accumulator));

            Instances.ConsoleOperator.Write_Line($"{exitCode}: exit code");
            Instances.ConsoleOperator.Write_Line("Output:");
            Instances.ConsoleOperator.Write_Lines(outputLines_Accumulator);
            Instances.ConsoleOperator.Write_Line("Error:");
            Instances.ConsoleOperator.Write_Lines(errorLines_Accumulator);

            return Task.CompletedTask;
        }
    }
}
