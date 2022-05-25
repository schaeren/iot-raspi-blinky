using System;
using System.Device.Gpio;

namespace iot.raspi.blinky
{
    class Program
    {
        static void Main(string[] margs)
        {
            Console.WriteLine("Blinking LED. Press Ctrl+C to end.");
            int ledPin = 18;
            using var controller = new GpioController();
            controller.OpenPin(ledPin, PinMode.Output);
            var loopCount = 1;
            while (true)
            { 
                Console.WriteLine($"loop {loopCount++}");

                controller.Write(ledPin, PinValue.High);
                Thread.Sleep(200);
                controller.Write(ledPin, PinValue.Low);
                Thread.Sleep(1000);
            }
        }
    }
}
