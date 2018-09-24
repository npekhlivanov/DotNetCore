using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unosquare.RaspberryIO.Gpio;
using static Unosquare.RaspberryIO.Pi;
using Unosquare.RaspberryIO.Native;

namespace Components
{

    public class Button
    {
        private GpioPin gpioPin;
        private ulong last_interrupt_time;

        public Button(GpioPin gpioPin)
        {
            this.gpioPin = gpioPin;

            Initialize();
        }

        private void Initialize()
        {
            gpioPin.InputPullMode = GpioPinResistorPullMode.PullDown;
            gpioPin.PinMode = GpioPinDriveMode.Input;
            gpioPin.RegisterInterruptCallback(EdgeDetection.RisingAndFallingEdges, OnClick);
        }

        private void OnClick()
        {
            if (!gpioPin.Read())
            {
                ulong interrupt_time = WiringPi.millis();
                if (interrupt_time - last_interrupt_time > 500)
                {
                    last_interrupt_time = interrupt_time;
                    Click?.Invoke(this, new EventArgs());
                }
            }
        }

        public event EventHandler<EventArgs> Click;
    }
}
