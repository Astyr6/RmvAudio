using System.Diagnostics;

namespace RmvAudio
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0) return; 
            var path = args[0];
            if (!path.EndsWith(".mp4")) path = args[0];
            var outputPath = path.Replace(".mp4", "_muted.mp4");
            Process.Start(new ProcessStartInfo("ffmpeg.exe", $"-i \"{path}\" -vcodec copy -an {outputPath}"));
        }
    }
}
