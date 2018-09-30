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
}
