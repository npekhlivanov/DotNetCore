using System;
using System.IO;

namespace TestWebApp.Services
{
    public class VideoStreamService : IVideoStreamService
    {
        readonly byte[] jsmpHeader = new byte[] { (byte)'j', (byte)'s', (byte)'m', (byte)'p' };

        public Stream GetVideoByName(string name)
        //public async Task<Stream> GetVideoByName(string name)
        {
            var fileName = string.Empty;
            switch (name)
            {
                case "video":
                    var outputStream = new MemoryStream();
                    outputStream.Write(jsmpHeader);
                    var width = BitConverter.GetBytes((UInt16)1920);
                    outputStream.Write(width);
                    var height = BitConverter.GetBytes((UInt16)1080);
                    outputStream.Write(height);

                    var inputfileName = @"D:\Projects\Others\R-Pi\RemoteFiles\video-h264";
                    fileName = @"D:\Projects\Others\R-Pi\RemoteFiles\video-mp4";
                    using (var logFile = new StreamWriter("FFMpegLog.txt"))
                    {
                        using (var ffmpeg = new FfmpegWrapper())
                        {
                            ffmpeg.ConvertStream(inputfileName, outputStream, logFile);

                            //using (var inputStream = new FileStream(inputfileName, FileMode.Open))
                            //{
                            //    ffmpeg.ConvertStream(inputStream, outputStream, logFile);
                            

                            //    //ffmpeg.ConvertFile(inputfileName, fileName, logFile);
                        }

                        logFile.Flush();
                    }
                    return (outputStream);

                case "nature":
                default:
                    fileName = @"D:\Projects\Others\R-Pi\RemoteFiles\nature2.mp4";
                    var fileStream = File.OpenRead(fileName);
                    return (fileStream);
            }

            //return await _client.GetStreamAsync(fileName);
        }
    }
}
