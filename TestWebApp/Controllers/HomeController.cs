using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


        public IActionResult Contact()
        {
            ViewData["LedState"] = true.ToString();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(bool ledState/*IFormCollection formCollection*/)
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
            return View();
        }

        public IActionResult CaptureImage()
        {
            if (Pi.Camera.IsBusy)
            {
                ViewData["Message"] = "Camera is busy!";
                return View();
            }

            var pin = Pi.Gpio.Pin21;
            pin.PinMode = GpioPinDriveMode.Output;
            pin.Write(true);

            CameraStillSettings settings = new CameraStillSettings
            {
                CaptureWidth = 640, // default
                CaptureHeight = 480, // default
                ImageFlipVertically = true,
                CaptureTimeoutMilliseconds = 900, // default for CaptureImageJpeg = 300 (min value recommended)
                //CaptureEncoding = CameraImageEncodingFormat.Jpg, // default
                CaptureJpegQuality = 95
            };
            
            var imageBytes = Pi.Camera.CaptureImage(settings);
            var targetPath = "./wwwroot/picture.jpg";
            if (System.IO.File.Exists(targetPath))
            {
                System.IO.File.Delete(targetPath);
            }
            System.IO.File.WriteAllBytes(targetPath, imageBytes);

            pin.Write(false);
            ViewData["Message"] = "Image captured.";

            return View("Image");
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
