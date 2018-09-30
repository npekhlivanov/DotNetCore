using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TestWebApp.Models;
//#if !DEBUG
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Camera;
using Unosquare.RaspberryIO.Computer;
using Unosquare.RaspberryIO.Gpio;
//#endif

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            AboutViewModel viewModel = new AboutViewModel
            {
                ModelInfo = AdditionalSystemInfo.GetModelInfo(),
                CpuTemperature = AdditionalSystemInfo.GetCpuTemperature()
           };

#if DEBUG
            ViewData["Message"] = "System information not available in Debug mode";
            viewModel.HostName = "Unknown";
            viewModel.RaspberryPiInfo = SystemInfo.Instance;
            viewModel.NetworkAdapterData = new List<NetworkAdapterInfo>();

#else
            ViewData["Message"] = "System information";
            viewModel.HostName = NetworkSettings.Instance.HostName;
            viewModel.RaspberryPiInfo = Pi.Info;
            viewModel.NetworkAdapterData = NetworkSettings.Instance.RetrieveAdapters();
#endif

            return View(viewModel);
        }

        public IActionResult Control()
        {
            ViewData["LedState"] = true.ToString();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Control(bool ledState/*IFormCollection formCollection*/)
        // if Html.CheckBox("ledState") is used in the view, it generates a hidden input with id="ledState" and value "false"
        // if <input type="checkbox" name="ledState" ...> is used, there is no default value and ledState is null if unchecked
        {
            //var ledStateValue = formCollection["ledState"];
            //var ledState = !string.IsNullOrEmpty(ledStateValue);
#if !DEBUG
            var pin = Pi.Gpio.Pin21;
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(ledState);
#else
            ViewData["Message"] = "Function not available in Debug mode";
#endif
            //var ledState2 = Request.Form["ledState"];
            //ViewData["LedState"] = (ledState ?? false).ToString();
            ViewData["LedState"] = ledState.ToString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Shutdown()
        {
#if !DEBUG
            Pi.Shutdown();
            ViewData["Message"] = "Shutdown invoked";
#else
            ViewData["Message"] = "Function not available in Debug mode";
#endif

            return View("Contact");
        }

        public IActionResult Image()
        {
            var viewModel = new ImageViewModel()
            {
                ImageEncoding = "jpg",
                Resolution = ImageViewModel.CameraResolution._1024x768,
                CaptureTimeoutMilliseconds = 500
            };
            return View(viewModel);
        }

        // 3280x2464 - 8MP?, or 3264x2448; 640x480 - 0.3 Megapixel; 1280x960 - 1MP; 1600x1200 - 2MP; 2560x1920 - 5MP
        private readonly int[] resolutionWidths = { 640, 1024, 1280, 1600, 2560 };
        private readonly int[] resolutionHeights = { 480, 768, 960, 1200, 1920 };

        private void ViewModelToCameraSettings(ImageViewModel viewModel, ref CameraStillSettings cameraSettings)
        {
            cameraSettings.CaptureWidth = resolutionWidths[(int)viewModel.Resolution];
            cameraSettings.CaptureHeight = resolutionHeights[(int)viewModel.Resolution];
            cameraSettings.CaptureTimeoutMilliseconds = viewModel.CaptureTimeoutMilliseconds;
            switch (viewModel.ImageEncoding)
            {
                case "jpg":
                    {
                        cameraSettings.CaptureEncoding = CameraImageEncodingFormat.Jpg;
                        break;
                    }
                case "png":
                    {
                        cameraSettings.CaptureEncoding = CameraImageEncodingFormat.Png;
                        break;
                    }
            }
        }

        [HttpPost]
        [ActionName("Image")]
        public IActionResult CaptureImage(ImageViewModel viewModel)
        {
            if (Pi.Camera.IsBusy)
            {
                ViewData["Message"] = "Camera is busy!";
                return View();
            }

            var pin = Pi.Gpio.Pin21;
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(true);

            // Prepare the camera settings object, getting the values from the ViewModel
            CameraStillSettings cameraSettings = new CameraStillSettings
            {
                CaptureTimeoutMilliseconds = 900, // default for CaptureImageJpeg = 300 (min value recommended)
                ImageFlipVertically = true,
                //CaptureEncoding = CameraImageEncodingFormat.Jpg, // default
                CaptureJpegQuality = 95
            };
            ViewModelToCameraSettings(viewModel, ref cameraSettings);
            
            // Take the picture with the camera settings and get image as bytes
            var imageBytes = Pi.Camera.CaptureImage(cameraSettings);

            // Encode the bytes to base64 and store in ViewModel
            var base64string = Convert.ToBase64String(imageBytes);
            viewModel.ImageData = base64string;

            //var targetPath = "./wwwroot/picture.jpg";
            //if (System.IO.File.Exists(targetPath))
            //{
            //    System.IO.File.Delete(targetPath);
            //}
            //System.IO.File.WriteAllBytes(targetPath, imageBytes);

            pin.Write(false);
            ViewData["Message"] = "Image captured.";

            return View(viewModel);
        }

        public IActionResult Video()
        {
            ViewData["Message"] = "Playing video";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
