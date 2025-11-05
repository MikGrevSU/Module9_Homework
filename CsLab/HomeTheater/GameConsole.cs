using System;

namespace HomeTheater
{
    public class GameConsole
    {
        bool isOn = false;

        public void On()
        {
            isOn = true;
            Console.WriteLine("GameConsole: on");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine("GameConsole: off");
        }

        public void LaunchGame(string game)
        {
            if (!isOn) On();
            Console.WriteLine($"GameConsole: launching '{game}'");
        }
    }
}
