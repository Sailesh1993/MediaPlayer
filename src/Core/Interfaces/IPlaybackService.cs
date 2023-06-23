namespace MediaPlayer.src.Core.Intefaces
{
    public interface IPlaybackService
    {
        void Play(string filePath);
        void Pause();
        void Stop();
        void Seek();
    }
}