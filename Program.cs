using System;
using System.Threading;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace LedSample
{
    class Program
    {
        private static readonly GpioPin ledPin = Pi.Gpio.Pin00; //led (ouput)
        private static readonly GpioPin buttonPin = Pi.Gpio.Pin07; //push button (input)

        static void Main(string[] args)
        {
            ledPin.PinMode = GpioPinDriveMode.Output;
            buttonPin.PinMode = GpioPinDriveMode.Input;
            buttonPin.InputPullMode = GpioPinResistorPullMode.PullDown;

            Console.WriteLine("Hello .NET Core on Raspberry PI!");
            while(true)
            {
                ledPin.Write(buttonPin.ReadValue());
                Thread.Sleep(100);
            }
            //for (var i = 0; i <5; i++)
            //{
            //    ledPin.Write(GpioPinValue.High);
            //    Thread.Sleep(500);
            //    ledPin.Write(GpioPinValue.Low);
            //    Thread.Sleep(500);
            //}


            Console.WriteLine("Program complete!");
        }
    }
}
