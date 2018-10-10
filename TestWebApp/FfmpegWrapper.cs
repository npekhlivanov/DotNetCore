using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TestWebApp
{
    public class FfmpegWrapper : IDisposable
    {
        private Process _process;
        private object _writeToLogLock = new object();

        public bool Started { get; private set; } = false;
        public bool Exited { get; private set; } = false;

        private void CreateProcess(string arguments, string fileName, DataReceivedEventHandler onOuputDataReceived, DataReceivedEventHandler onErrorDataReceived, EventHandler onProcessExited)
        {
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                //WorkingDirectory = @"D:\Install\ffmpeg-20181005-50a2347-win64-static\bin\",
                FileName = fileName,
                Arguments = arguments
            };

            _process = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true
            };

            if (onOuputDataReceived != null)
            {
                _process.OutputDataReceived += onOuputDataReceived;
            }

            if (onErrorDataReceived != null)
            {
                _process.ErrorDataReceived += onErrorDataReceived;
            }

            if (onProcessExited != null)
            {
                _process.Exited += onProcessExited;
            }
        }

        public bool ConvertStream(Stream inputStream, string outputFile, StreamWriter logWriter)
        {
            if (inputStream == null)
            {
                throw new ArgumentNullException("input stream must be assigned!");
            }

            if (string.IsNullOrEmpty(outputFile))
            {
                throw new ArgumentNullException("output file name must be specified!");
            }

            var inputArgs = "-f h264 -i -"; // must be -r 20; consider using -nostdin; replace -video_size with -s:v 1920x1080
            var outputArgs = $"-f mp4 -r 20 \"{outputFile}\" -y";
            //var inputArgs = "-framerate 20 -f rawvideo -pix_fmt rgb32 -video_size 1920x1080 -i -"; must be -r 20; consider using -nostdin; replace -video_size with -s:v 1920x1080
            //var outputArgs = "-vcodec libx264 -crf 23 -pix_fmt yuv420p -preset ultrafast -r 20 out.mp4";

            CreateProcess($"-hide_banner {inputArgs} {outputArgs}", @"D:\Install\ffmpeg-20181005-50a2347-win64-static\bin\ffmpeg.exe",
               (object sendingProcess, DataReceivedEventArgs e) =>
               {
                   if (e.Data != null)
                   {
                       WriteToLog(e.Data, logWriter);
                   }
               },
               (object sendingProcess, DataReceivedEventArgs e) =>
               {
                   if (e.Data != null)
                   {
                       WriteToLog(e.Data, logWriter);
                   }
               },
               (object sender, EventArgs e) =>
               {
                   Exited = true;
               }
            );
            try
            {
                Started = _process.Start();

                var ffmpegIn = _process.StandardInput.BaseStream;
                inputStream.CopyTo(ffmpegIn, 16384); // freezes here
                //ffmpegIn.Flush();
                
                // Start the asynchronous read of the output stream
                _process.BeginOutputReadLine();
                // Start the asynchronous read of the standard error stream
                _process.BeginErrorReadLine();
                _process.WaitForExit(3000);
                //Thread.Sleep(500);
            }
            catch (Exception e)
            {
                logWriter.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool ConvertFile(string inputFile, string outputFile, StreamWriter logWriter)
        {
            if (!File.Exists(inputFile))
            {
                throw new ArgumentException($"File \"{inputFile}\" must exist!");
            }

            var arguments = $"-hide_banner -f h264 -i \"{inputFile}\" -c:v copy -f mp4 -r 20 \"{outputFile}\" -y";
            CreateProcess(arguments, @"D:\Install\ffmpeg-20181005-50a2347-win64-static\bin\ffmpeg.exe",
                (object sendingProcess, DataReceivedEventArgs e) =>
                {
                    if (e.Data != null)
                    {
                        WriteToLog(e.Data, logWriter);
                    }
                },
                (object sendingProcess, DataReceivedEventArgs e) =>
                {
                    if (e.Data != null)
                    {
                         WriteToLog(e.Data, logWriter);
                    }
                },
                (object sender, EventArgs e) =>
                {
                    Exited = true;
                }
            );

            try
            {
                //Console.InputEncoding = Encoding.ASCII;
                
                Started = _process.Start();

                // Start the asynchronous read of the output stream
                _process.BeginOutputReadLine();
                // Start the asynchronous read of the standard error stream
                _process.BeginErrorReadLine();
                _process.WaitForExit(3000);
                //Thread.Sleep(500);
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

        private void WriteToLog(string line, StreamWriter logWriter)
        {
            if (logWriter != null)
            {
                Monitor.Enter(_writeToLogLock);
                try
                {
                    logWriter.WriteLine(line);
                }
                finally
                {
                    Monitor.Exit(_writeToLogLock);
                }
            }
        }

        private async Task WriteToLogAsync(string line, StreamWriter logWriter)
        {
            if (logWriter != null)
            {
                    await logWriter.WriteLineAsync(line);
            }
        }
    }
}
