using System;

namespace HomeTheater
{
    public class AudioSystem
    {
        bool isOn = false;
        int volume = 50;
        string input = "AUX";

        public void On()
        {
            isOn = true;
            Console.WriteLine("AudioSystem: on");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine("AudioSystem: off");
        }

        public void SetVolume(int vol)
        {
            volume = Math.Max(0, Math.Min(100, vol));
            Console.WriteLine($"AudioSystem: volume {volume}");
        }

        public void SetInput(string inputSource)
        {
            input = inputSource;
            Console.WriteLine($"AudioSystem: input {input}");
        }
    }
}
