using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp
{
    public class FfmpegWrapper : IDisposable
    {
        private Process _process;

        public bool ConvertFile(string inputFile, string outputFile)
        {
            if (!File.Exists(inputFile))
            {
                throw new ArgumentException($"File \"{inputFile}\" must exist!");
            }

            //if (!Path.GetExtension(outputFile).ToLower().Equals("mp4"))
            //{
            //    throw new ArgumentException($"File \"{outputFile}\" must have extension \".mp4\"!");
            //}

            var arguments = $"-f h264 -i \"{inputFile}\" -c:v copy -f mp4 \"{outputFile}\" -y";
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                WorkingDirectory = @"D:\Install\ffmpeg-20181005-50a2347-win64-static\bin\",
                FileName = @"D:\Install\ffmpeg-20181005-50a2347-win64-static\bin\ffmpeg.exe",
                Arguments = arguments
            };

            _process = new Process
            {
                StartInfo = startInfo
            };

            try
            {
                //Console.InputEncoding = Encoding.ASCII;

                _process.EnableRaisingEvents = true;
                _process.OutputDataReceived += (object sendingProcess, DataReceivedEventArgs e) =>
                {
                    if (e.Data != null)
                    {
                        Console.WriteLine(e.Data);
                    }
                };

                _process.ErrorDataReceived += (object sendingProcess, DataReceivedEventArgs e) =>
                {
                    if (e.Data != null)
                    {
                        Console.WriteLine(e.Data);
                    }
                };

                _process.Start();

                _process.BeginOutputReadLine();
                _process.BeginErrorReadLine();
            }
            catch (Exception e)
            {
                //MMALLog.Logger.Fatal(e.Message);
                throw e;
            }

            return true;
        }

        public void Dispose()
        {
            if (!_process.HasExited)
            {
                _process.Kill();
            }
        }
    }
}
