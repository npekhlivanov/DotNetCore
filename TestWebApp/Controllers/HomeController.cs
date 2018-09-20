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
#if DEBUG
            ViewData["Message"] = "System information not available in Debug mode";
            return View();
#else
            ViewData["Message"] = "System information";
            AboutViewModel viewModel = new AboutViewModel
            {
                RaspberryPiInfo = Pi.Info
            };
            return View(viewModel);
#endif
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
