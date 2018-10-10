using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Camera;

namespace TestWebApp
{
    public class CameraVideoStream
    {
        private Stream _stream;

        public CameraVideoStream()
        {
#if DEBUG
            _stream = new FileStream(@"D:\Projects\Others\R-Pi\RemoteFiles\video.h264", FileMode.Open);
#else
            _stream = new MemoryStream();
#endif
        }

        ~CameraVideoStream()
        {
            if (_stream != null)
            {
                _stream.Dispose();
            }
        }

        public bool IsActive { get; private set; } = false;

        public void Open(CameraVideoSettings cameraSettings)
        {
            if (IsActive)
            {
                return; // or raise exception ?
            }

            //if (_stream != null)
            //{
            //    _stream.Close();
            //}


#if DEBUG
            Pi.Camera.OpenVideoStream(cameraSettings, 
                onDataCallback: (byte[] data) =>
                {
                    if (IsActive && _stream.CanWrite)
                    {
                        _stream.Write(data);
                    }
                },
                onExitCallback: () => 
                {
                    IsActive = false;
                });
#endif
            IsActive = true;
        }

        public void Close()
        {
            if (!IsActive)
            {
                return;
            }

            Pi.Camera.CloseVideoStream();
        }
    }

    /*
     * https://github.com/waveform80/pistreaming
     * https://github.com/waveform80/pistreaming/blob/master/server.py
     * The BroadcastOutput class is an implementation of a picamera custom output. On initialization it starts a background FFmpeg process (avconv) which is configured 
     * to expect raw video data in YUV420 format, and will encode it as MPEG1. As unencoded video data is fed to the output via the write method, the class feeds the data 
     * to the background FFmpeg process.
     * 
class BroadcastOutput(object):
    def __init__(self, camera):
        print('Spawning background conversion process')
        self.converter = Popen([
            'ffmpeg',
            '-f', 'rawvideo',
            '-pix_fmt', 'yuv420p',
            '-s', '%dx%d' % camera.resolution,
            '-r', str(float(camera.framerate)),
            '-i', '-',
            '-f', 'mpeg1video',
            '-b', '800k',
            '-r', str(float(camera.framerate)),
            '-'],
            stdin=PIPE, stdout=PIPE, stderr=io.open(os.devnull, 'wb'),
            shell=False, close_fds=True)

    def write(self, b):
        self.converter.stdin.write(b)

    def flush(self):
        print('Waiting for background conversion process to exit')
        self.converter.stdin.close()
self.converter.wait() 

    TESTED: ffmpeg -i ../videos/1.avi -c copy ../Videos/video2.mp4 => produces a file that is played in the browser
    TRY: ffmpeg -framerate 24 -i input.264 -c copy output.mp4

    public void Create(string input, string output, string parametri, string ThumbnailPhysicalPath, int ConvertType)
        {
            ffmpeg = new Process();

            if (ConvertType == Convert.ToInt32(ConversionType.Thumbnail))
                ffmpeg.StartInfo.Arguments = " -i \"" + input + "\" -vframes 1 \"" + output + "\"";
            else if (ConvertType == Convert.ToInt32(ConversionType.AviToMp4))
                ffmpeg.StartInfo.Arguments = " -i \"" + input + "\" -c:v libx264 -b:a 128k -vcodec mpeg4 -b:v 1200k -flags +aic+mv4 \"" + output + "\"";
                //ffmpeg.StartInfo.Arguments = " -i \"" + input + "\" -vcodec libx264 -vprofile high -preset slow -b:v 500k -maxrate 500k -bufsize 1000k -vf scale=-1:480 -threads 0 -acodec libvo_aacenc -b:a 128k -pix_fmt yuv420p \"" + output + "\"";
            ffmpeg.StartInfo.FileName = ThumbnailPhysicalPath + @"ffmpeg.exe";
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.CreateNoWindow = true;
            try
            {
                ffmpeg.Start();
                ffmpeg.WaitForExit();
                string error = ffmpeg.StandardError.ReadToEnd();
            }
            catch (Exception Ex)
            {
                Common.WriteLog("Exception occurred during conversion. Error Message :- " + Ex.Message + "\n Input Parameter :- " + input+ "\n Output Paramenter :- "+ output);
            }
            finally
            {
                ffmpeg.Close();
                if (ConvertType == Convert.ToInt32(ConversionType.AviToMp4))
                    UpdateConvertedVideoDetails(input,output);
            }
        }

     */
}
