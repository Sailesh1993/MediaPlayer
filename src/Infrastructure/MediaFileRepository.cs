namespace MediaPlayer.src.Infrastructure
{
    public class MediaFileRepository
    {
        private static MediaFileRepository? _instance;
        private static readonly object _lockObject = new object();
        private readonly HashSet<string> _mediaFiles;

        private MediaFileRepository()
        {
            _mediaFiles = new HashSet<string>();
        }
        public static MediaFileRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new MediaFileRepository();
                        }
                    }
                }
                return _instance;
            }
            
        }
        
        public bool RemoveMediaFile(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                return false;
            }
            lock(_lockObject)
            {
                return _mediaFiles.Remove(filePath);
            }
        }

        public List<string> GetAllMediaFiles()
        {
            lock(_lockObject)
            {
                return _mediaFiles.ToList();
            }
        }
    }
}