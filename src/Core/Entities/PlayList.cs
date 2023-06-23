namespace MediaPlayer.src.Core.Entities
{
    public class Playlist
    {
        public int ID { get; private set;}
        public string Name { get; private set;}
        private List<MediaFile> _mediaFiles;

        public Playlist (string name)
        {
            Name = name;
            _mediaFiles = new List<MediaFile>();
        }
        public void AddMediaFile(MediaFile mediaFile)
        {

        }
    }
}