using MediaPlayer.src.Core.Intefaces;

namespace MediaPlayer.src.Core.Services
{
    public class AudioPlayerService : IPlaybackService
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing audio file: " + filePath);
        }
        public void Pause()
        {
            Console.WriteLine("Audio Paused");
        }
         public void Stop()
        {
            Console.WriteLine("Audio Stopped");
        }
        public void Seek()
        {
            throw new NotImplementedException();
        }
    }
}