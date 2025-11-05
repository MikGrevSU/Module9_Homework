using System;

namespace HomeTheater
{
    public class TV
    {
        bool isOn = false;
        int channel = 1;

        public void On()
        {
            isOn = true;
            Console.WriteLine("TV: on");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine("TV: off");
        }

        public void SetChannel(int ch)
        {
            channel = ch;
            Console.WriteLine($"TV: set channel {channel}");
        }
    }
}
