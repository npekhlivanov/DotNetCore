using System;
using System.Linq;
using System.Threading.Tasks;
using Xabe.FFmpeg;
using Xabe.FFmpeg.Enums;
using Xabe.FFmpeg.Streams;

namespace TestFFMpeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert(@"D:\Projects\Others\R-Pi\RemoteFiles\video-h264", @"D:\Projects\Others\R-Pi\RemoteFiles\video-mp4").Wait(5000);//.GetAwaiter().GetResult();
        }

        private static async Task Convert(string inputFile, string outputFile)
        {
            await Console.Out.WriteLineAsync($"Converting {inputFile} to {outputFile} ...");
            FFmpeg.ExecutablesPath = @"D:\Install\ffmpeg-20181005-50a2347-win64-static\bin";
            //await FFmpeg.GetLatestVersion();

            var mediaInfo = await MediaInfo.Get(inputFile);
            var videoStream = mediaInfo.VideoStreams.First();
            //var audioStream = mediaInfo.AudioStreams.First();

            videoStream.SetCodec(VideoCodec.H264);

            var conversion = Conversion.New()
                .AddStream(videoStream)
                .SetOutput(outputFile)
                .SetOverwriteOutput(true)
                .UseMultiThread(false);

            conversion.OnProgress += async (sender, args) =>
            {
                //Show all output from FFmpeg to console
                await Console.Out.WriteLineAsync($"[{args.Duration}/{args.TotalLength}][{args.Percent}%]");
            };
            //Start conversion
            await conversion.Start();

            await Console.Out.WriteLineAsync($"Finished converion file [{inputFile}]");
        }
    }
}
