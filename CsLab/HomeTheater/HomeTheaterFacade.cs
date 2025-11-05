using System;

namespace HomeTheater
{
    public class HomeTheaterFacade
    {
        TV tv;
        AudioSystem audio;
        DVDPlayer dvd;
        GameConsole console;

        public HomeTheaterFacade(TV tv, AudioSystem audio, DVDPlayer dvd, GameConsole console)
        {
            this.tv = tv;
            this.audio = audio;
            this.dvd = dvd;
            this.console = console;
        }

        public void WatchMovie(string movie, int channel = 1, int volume = 30)
        {
            tv.On();
            tv.SetChannel(channel);
            audio.On();
            audio.SetInput("DVD");
            audio.SetVolume(volume);
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            dvd.Stop();
            audio.Off();
            tv.Off();
        }

        public void ListenMusic(int channel = 1, int volume = 40)
        {
            tv.On();
            tv.SetChannel(channel);
            audio.On();
            audio.SetInput("TV");
            audio.SetVolume(volume);
        }

        public void StopMusic()
        {
            audio.Off();
            tv.Off();
        }

        public void PlayGame(string game, int volume = 50)
        {
            tv.On();
            audio.On();
            audio.SetInput("Console");
            audio.SetVolume(volume);
            console.On();
            console.LaunchGame(game);
        }

        public void TurnOffAll()
        {
            dvd.Stop();
            console.Off();
            audio.Off();
            tv.Off();
        }

        public void SetVolume(int volume)
        {
            audio.SetVolume(volume);
        }
    }
}
