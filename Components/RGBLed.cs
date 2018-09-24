using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unosquare.RaspberryIO.Gpio;
using static Unosquare.RaspberryIO.Pi;
using Unosquare.RaspberryIO.Native;

namespace Components
{

    public class RGBLed
    {
        private GpioPin redPin;
        private GpioPin greenPin;
        private GpioPin bluePin;

        public RGBLed(GpioPin redPin, GpioPin greenPin, GpioPin bluePin)
        {
            this.redPin = redPin;
            this.greenPin = greenPin;
            this.bluePin = bluePin;

            Initialize();
        }

        private void Initialize()
        {
            redPin.PinMode = GpioPinDriveMode.Output;
            greenPin.PinMode = GpioPinDriveMode.Output;
            bluePin.PinMode = GpioPinDriveMode.Output;

            redPin.StartSoftPwm(0, 225);
            greenPin.StartSoftPwm(0, 225);
            bluePin.StartSoftPwm(0, 225);
        }

        public bool State
        {
            get => redPin.SoftPwmValue > 0 || greenPin.SoftPwmValue > 0 || bluePin.SoftPwmValue > 0;
            set
            {
                redPin.SoftPwmValue = value ? 255 : 0;
                greenPin.SoftPwmValue = value ? 255 : 0;
                bluePin.SoftPwmValue = value ? 255 : 0;
            }
        }

        public int Red
        {
            get => redPin.SoftPwmValue;
            set => redPin.SoftPwmValue = value;
        }

        public int Green
        {
            get => greenPin.SoftPwmValue;
            set => greenPin.SoftPwmValue = value;
        }

        public int Blue
        {
            get => bluePin.SoftPwmValue;
            set => bluePin.SoftPwmValue = value;
        }
    }
}
