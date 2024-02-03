using RazorPagesMovie.Constants;

namespace RazorPagesMovie.Utils
{
    public static class LogConsole
    {
        public static void Log(string message)
        {
            Console.WriteLine(ConsoleTags.LogTag + message);
        }
    }
}
