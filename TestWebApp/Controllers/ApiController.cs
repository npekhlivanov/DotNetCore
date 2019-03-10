using Microsoft.AspNetCore.Mvc;
using TestWebApp.Services;

namespace TestWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamingController : ControllerBase
    {
        private IVideoStreamService _streamService;

        public StreamingController(IVideoStreamService streamingService)
        {
            _streamService = streamingService;
        }

        [HttpGet("{name}")]
        public FileStreamResult Get(string name)
        {
            var stream = _streamService.GetVideoByName(name);
            stream.Position = 0;
            return new FileStreamResult(stream, "video/mp4");
        }
    }
}