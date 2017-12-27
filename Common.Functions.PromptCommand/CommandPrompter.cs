using System.Diagnostics;

namespace Common.Functions.PromptCommand
{
    public static class CommandPrompter
    {
        private const string CommandExe = "cmd.exe";

        public static Process Prompt()
            => Process.Start(new ProcessStartInfo
            {
                CreateNoWindow = true,
                FileName = CommandExe,
                RedirectStandardInput = true,
                UseShellExecute = false
            });
    }
}
