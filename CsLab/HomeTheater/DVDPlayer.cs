using System;

namespace HomeTheater
{
    public class DVDPlayer
    {
        bool isPlaying = false;

        public void Play(string movie)
        {
            isPlaying = true;
            Console.WriteLine($"DVDPlayer: playing '{movie}'");
        }

        public void Pause()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("DVDPlayer: paused");
            }
        }

        public void Stop()
        {
            isPlaying = false;
            Console.WriteLine("DVDPlayer: stopped");
        }
    }
}
