using MediaPlayer.src.Core.Intefaces;

namespace MediaPlayer.src.Core.Services
{
    public class VideoPlayerService : IPlaybackService 
    {
        public void Play (string filePath)
        {
            Console.WriteLine($"Playing video :" + filePath);
        }
        public void Pause()
        {
            Console.WriteLine("Video paused");
        }
        public void Stop()
        {
            Console.WriteLine("Video Stopped");
        }
        public void Seek()
        {
            throw new NotImplementedException();
        }

    }
}