using System;

namespace HomeTheater
{
    public class HomeTheaterProgram
    {
        public static void Run()
        {
            TV tv = new TV();
            AudioSystem audio = new AudioSystem();
            DVDPlayer dvd = new DVDPlayer();
            GameConsole console = new GameConsole();

            HomeTheaterFacade home = new HomeTheaterFacade(tv, audio, dvd, console);

            home.WatchMovie("Inception", 5, 25);
            home.EndMovie();

            home.ListenMusic(3, 35);
            home.SetVolume(45);
            home.StopMusic();

            home.PlayGame("Super Mario", 60);
            home.TurnOffAll();
        }
    }
}

