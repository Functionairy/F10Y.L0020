using System;


namespace F10Y.L0020
{
    public class CommandResult
    {
        public string[] OutputLines { get; }
        public string[] ErrorLines { get; }
        public int ExitCode { get; }
        public TimeSpan Duration { get; }


        public CommandResult(
            string[] outputLines,
            string[] errorLines,
            int exitCode,
            TimeSpan duration)
        {
            this.OutputLines = outputLines;
            this.ErrorLines = errorLines;
            this.ExitCode = exitCode;
            this.Duration = duration;
        }
    }
}


namespace F10Y.L0020.N001
{
    public class CommandResult
    {
        public int ExitCode { get; }
        public TimeSpan Duration { get; }


        public CommandResult(
            int exitCode,
            TimeSpan duration)
        {
            this.ExitCode = exitCode;
            this.Duration = duration;
        }
    }
}
