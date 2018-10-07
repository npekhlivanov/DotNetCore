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
                    using (var ffmpeg = new FfmpegWrapper())
                    {
                        ffmpeg.ConvertFile(inputfileName, fileName);
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
