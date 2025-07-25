using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using F10Y.L0000.Extensions;
using F10Y.T0002;


namespace F10Y.L0020
{
    [FunctionsMarker]
    public partial interface ICommandResultOperator
    {
        public IEnumerable<string> Describe(CommandResult commandResult)
        {
            var lines = Instances.EnumerableOperator.New<string>()
                .Append($"{commandResult.ExitCode}: exit code")
                .Append($"{commandResult.Duration}: duration")
                .Append("\nOutput:")
                .Append(commandResult.OutputLines)
                .Append("\nError:")
                .Append(commandResult.ErrorLines)
                ;

            return lines;
        }

        public void Describe_ToConsole_Synchronous(CommandResult commandResult)
            => this.Describe_ToTextWriter_Synchronous(
                commandResult,
                Instances.Values.Console_Out);

        public async Task Describe_ToFile(
            CommandResult commandResult,
            string textFilePath)
        {
            var lines = this.Describe(commandResult);

            await Instances.FileOperator.Write_Lines(
                textFilePath,
                lines);
        }

        public async Task Describe_ToFile(
            CommandResult commandResult,
            string textFilePath,
            CommandInvocation command)
        {
            var command_Lines = Instances.CommandInvocationOperator.Describe_ToLines(command)
                .Append_BlankLine()
                ;

            var result_Lines = this.Describe(commandResult);

            var lines_ForOutput = Instances.EnumerableOperator.From(
                command_Lines,
                result_Lines);

            await Instances.FileOperator.Write_Lines(
                textFilePath,
                lines_ForOutput);
        }

        public void Describe_ToTextWriter_Synchronous(
            CommandResult commandResult,
            TextWriter textWriter)
        {
            var lines = this.Describe(commandResult);

            Instances.TextWriterOperator.Write_Lines_Synchronous(
                Instances.Values.Console_Out,
                lines);
        }

        public CommandResult Get_From(
            string[] outputLines,
            string[] errorLines,
            int exitCode,
            TimeSpan duration)
            => new CommandResult(
                outputLines,
                errorLines,
                exitCode,
                duration);

        public N001.CommandResult Get_From(
            int exitCode,
            TimeSpan duration)
            => new N001.CommandResult(
                exitCode,
                duration);

        public bool Is_Success(CommandResult commandResult)
        {
            var output = Instances.ExitCodeOperator.Is_Success(
                commandResult.ExitCode);

            return output;
        }
    }
}
