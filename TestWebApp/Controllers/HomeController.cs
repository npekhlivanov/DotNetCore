using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;
#if !DEBUG
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;
#endif

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
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
#if DEBUG
            ViewData["Message"] = "System information not available in Debug mode"; 
#else
            ViewData["Message"] = string.Format("Model: {0}, Hardware: {1}, SN: {2}", Pi.Info.ModelName, Pi.Info.Hardware, Pi.Info.Serial);
#endif
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
#endif
            //var ledState2 = Request.Form["ledState"];
            //ViewData["LedState"] = (ledState ?? false).ToString();
            ViewData["LedState"] = ledState.ToString();
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
