using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unosquare.RaspberryIO.Gpio;
using static Unosquare.RaspberryIO.Pi;
using Unosquare.RaspberryIO.Native;

namespace Components
{

    public class Led
    {
        private GpioPin gpioPin;

        public Led(GpioPin gpioPin)
        {
            this.gpioPin = gpioPin;

            Initialize();
        }

        private void Initialize()
        {
            gpioPin.PinMode = GpioPinDriveMode.Output;
        }

        public bool State
        {
            get => gpioPin.Read();
            set => gpioPin.Write(value);
        }
    }
}
