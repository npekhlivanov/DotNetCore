using System.IO;

namespace TestWebApp.Services
{
    public interface IVideoStreamService
    {
        Stream GetVideoByName(string name);
    }
}
