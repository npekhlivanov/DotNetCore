using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Computer;
using Unosquare.RaspberryIO.Gpio;

namespace TestWebApp.Models
{
    public class AboutViewModel
    {
        public SystemInfo RaspberryPiInfo { get; set; }
    }
}
