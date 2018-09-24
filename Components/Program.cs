using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Unosquare.RaspberryIO.Gpio;
using static Unosquare.RaspberryIO.Pi;
using Unosquare.RaspberryIO.Native;
using Components;

namespace IotCamera
{
    static class Program
    {
        private static Led led;
        private static RGBLed rgbLed;
        private static Relay relay;
        private static Button button;

        async static Task Main(string[] args)
        {
            // Initialize
            // LED
            led = new Led(Gpio.Pin21);

            // RGB LED
            rgbLed = new RGBLed(Gpio.Pin28, Gpio.Pin29, Gpio.Pin03);

            // Relay
            relay = new Relay(Gpio.Pin04);

            CancellationTokenSource cts = null;

            // Button
            button = new Button(Gpio.Pin22);
            button.Click += async (s, e) =>
            {
                cts = new CancellationTokenSource();
                StartBlinking(cts.Token);

                relay.State = true;

                if (Camera.IsBusy)
                {
                    Console.WriteLine("Camera is busy.");
                    return;
                }
                led.State = true;
                Console.WriteLine("Capturing image...");
                var result = await Camera.CaptureImageJpegAsync(3280, 2464, default);
                await File.WriteAllBytesAsync($"image-{DateTime.UtcNow.Ticks}.jpg", result);
                led.State = false;
                Console.WriteLine("Image captured.");

                await Task.Delay(3000);

                relay.State = false;

                cts.Cancel();
            };

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void StartBlinking(CancellationToken token)
        {
            Task.Run(() => Blink(token), token);
        }

        private static async Task Blink(CancellationToken ct)
        {
            while (true)
            {
                if (ct.IsCancellationRequested)
                    break;

                SetColor(225, 0, 0);

                await Task.Delay(1000);

                if (ct.IsCancellationRequested)
                    break;

                SetColor(0, 225, 0);

                await Task.Delay(1000);

                if (ct.IsCancellationRequested)
                    break;

                SetColor(0, 0, 225);

                await Task.Delay(1000);
            }

            rgbLed.State = false;
        }

        private static void SetColor(int r, int g, int b)
        {
            rgbLed.Red = r;
            rgbLed.Green = g;
            rgbLed.Blue = b;
        }
    }
}
