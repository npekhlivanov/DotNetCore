using System.IO;

namespace TestWebApp.Services
{
    public class VideoStreamService : IVideoStreamService
    {
        public Stream GetVideoByName(string name)
        //public async Task<Stream> GetVideoByName(string name)
        {
            var fileName = string.Empty;
            switch (name)
            {
                case "video":
                    var inputfileName = @"D:\Projects\Others\R-Pi\RemoteFiles\video-h264";
                    fileName = @"D:\Projects\Others\R-Pi\RemoteFiles\video-mp4";
                    using (var logFile = new StreamWriter("FFMpegLog.txt"))
                    {
                        using (var ffmpeg = new FfmpegWrapper())
                        {
                            using (var inputStream = new FileStream(inputfileName, FileMode.Open))
                                ffmpeg.ConvertStream(inputStream, fileName, logFile);
                                //ffmpeg.ConvertFile(inputfileName, fileName, logFile);
                        }

                        logFile.Flush();
                    }
                    break;
                case "nature":
                default:
                    fileName = @"D:\Projects\Others\R-Pi\RemoteFiles\nature2.mp4";
                    break;
            }

            var fileStream = File.OpenRead(fileName);
            return (fileStream);
            //return await _client.GetStreamAsync(fileName);
        }
    }
}
