using MMALSharp;
using MMALSharp.Components;
using MMALSharp.Handlers;
using MMALSharp.Native;
using Nito.AsyncEx;
using System;
using System.Threading;
using System.Threading.Tasks;
using static MMALSharp.Native.MMALParametersVideo;

namespace TestCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                if (args[0].Equals("video"))
                {
                    Console.WriteLine("Starting video capture");
                    TakeVideoAsync().Wait();
                    Console.WriteLine("Finished capturing video");
                    return;
                }

                if (args[0].Equals("picture"))
                {
                    TakePictureAsync().Wait();
                    Console.WriteLine("Finished takinging picture");
                        return;
                }
            }

            Console.WriteLine("Please specify <picture> or <video>");
            return;
            }

        public static async Task TakePictureAsync()
        {
            MMALCameraConfig.Annotate = new AnnotateImage
            {
                ShowDateText = true,
                ShowTimeText = true
            };
            MMALCameraConfig.StatsPass = true;
            // Singleton initialized lazily. Reference once in your application.
            MMALCamera cam = MMALCamera.Instance;

            using (var imgCaptureHandler = new ImageStreamCaptureHandler("/home/pi/images/", "jpg"))
            {
                await cam.TakePicture(imgCaptureHandler, MMALEncoding.JPEG, MMALEncoding.I420);
            }

            // Cleanup disposes all unmanaged resources and unloads Broadcom library. To be called when no more processing is to be done
            // on the camera.
            cam.Cleanup();
        }

        public static async Task TakeVideoAsync()
        {
            MMALCameraConfig.VideoResolution = new Resolution(640, 480);
            MMALCameraConfig.Flips = MMAL_PARAM_MIRROR_T.MMAL_PARAM_MIRROR_VERTICAL;
            MMALCameraConfig.InlineHeaders = true;
            MMALCameraConfig.VideoProfile = MMAL_VIDEO_PROFILE_T.MMAL_VIDEO_PROFILE_H264_HIGH;
            // Singleton initialized lazily. Reference once in your application.
            MMALCamera cam = MMALCamera.Instance;

            using (var vidCaptureHandler = new VideoStreamCaptureHandler("/home/pi/videos/", "avi"))
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                await cam.TakeVideo(vidCaptureHandler, cts.Token);
            }

            // Cleanup disposes all unmanaged resources and unloads Broadcom library. To be called when no more processing is to be done
            // on the camera.
            cam.Cleanup();
        }

        public static void TakePictureManualMode()
        {
            MMALCamera cam = MMALCamera.Instance;

            AsyncContext.Run(async () =>
            {
                using (var imgCaptureHandler = new ImageStreamCaptureHandler("/home/pi/images/", "jpg"))
                using (var imgEncoder = new MMALImageEncoder(imgCaptureHandler))
                using (var nullSink = new MMALNullSinkComponent())
                {
                    cam.ConfigureCameraSettings();

                    // Create our component pipeline.         
                    imgEncoder.ConfigureOutputPort(0, MMALEncoding.JPEG, MMALEncoding.I420, 90);

                    cam.Camera.StillPort.ConnectTo(imgEncoder);
                    cam.Camera.PreviewPort.ConnectTo(nullSink);

                    // Camera warm up time
                    await Task.Delay(2000);
                    await cam.ProcessAsync(cam.Camera.StillPort);
                }

            });

            cam.Cleanup();
        }

        public static void TakeVideoManualMode()
        {
            MMALCamera cam = MMALCamera.Instance;

            AsyncContext.Run(async () =>
            {
                //using (var vidCaptureHandler = new VideoStreamCaptureHandler("/home/pi/videos/", "mjpeg"))
                using (var vidCaptureHandler = new VideoStreamCaptureHandler("/home/pi/videos/", "avi"))
                using (var vidEncoder = new MMALVideoEncoder(vidCaptureHandler))
                //using (var ffCaptureHandler = FFmpegCaptureHandler.RawVideoToAvi("/home/pi/videos/", "testing1234"))
                //using (var vidEncoder = new MMALVideoEncoder(ffCaptureHandler))
                using (var renderer = new MMALVideoRenderer())
                {
                    cam.ConfigureCameraSettings();

                    // Create our component pipeline. Here we are using the H.264 standard with a YUV420 pixel format. The video will be taken at 25Mb/s.
                    vidEncoder.ConfigureOutputPort(0, MMALEncoding.MJPEG, MMALEncoding.I420, 90, 25000000);

                    cam.Camera.VideoPort.ConnectTo(vidEncoder);
                    cam.Camera.PreviewPort.ConnectTo(renderer);

                    // Camera warm up time
                    await Task.Delay(2000);

                    var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                    // Take video for 3 minutes.
                    await cam.ProcessAsync(cam.Camera.VideoPort, cts.Token);
                }

            });

            cam.Cleanup();
        }
    }
}
