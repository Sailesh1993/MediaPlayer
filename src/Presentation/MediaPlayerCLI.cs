using MediaPlayer.src.Core.Services;

namespace MediaPlayer.src.Presentation
{
    public class MediaPlayerCLI
    {
        private readonly AudioPlayerService _audioPlaybackService;
        private readonly VideoPlayerService _videoPlaybackService;
        private readonly PlaylistService _playlistService;
        private bool _isVideoPlayerSelected;
    
        public MediaPlayerCLI()
        {
            _audioPlaybackService = new AudioPlayerService();
            _videoPlaybackService = new VideoPlayerService();
            _playlistService = new PlaylistService();
            _isVideoPlayerSelected = false;
        }

        public void Run()
        {
            Console.WriteLine("Hungama Media Player");
            while(true)
            {
                DisplayMainMenu();
                string? userInut = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        _isVideoPlayerSelected = false;
                        PlayAction();
                        break;
                    case "2":
                        _isVideoPlayerSelected = true;
                        PlayAction();
                        break;
                    case "3":
                        PauseAction();
                        break;
                    case "4":
                        StopAction();
                        break;
                    case "5":
                        break;
                    case "6":
                        CreatePlaylistAction();
                        break;
                    case "7":
                        AddFileToPlaylist();
                        break;
                    case "8":
                        RemoveMediaFromPlaylistAction();
                        break;
                    case "0":
                        Console.WriteLine("Thanks for using Hungama Media Player");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, Please try again");
                        break;
                }
            }
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1. Play Music");
            Console.WriteLine("2. Play Video");
            Console.WriteLine("3. Pause");
            Console.WriteLine("4. Stop");
            Console.WriteLine("5. Seek");
            Console.WriteLine("6. Create Playlist");
            Console.WriteLine("7. Add file to playlist");
            Console.WriteLine("8. Remove file form playlist");
            Console.Write("Enter your choice: ");
        }

        private void PlayAction()
        {
            Console.Write("Enter the file path: ");
            string? filePath = Console.ReadLine();
            if(filePath != null)
            {
                if(_isVideoPlayerSelected)
                {
                    _videoPlaybackService.Play(filePath);
                }
                else
                {
                    _audioPlaybackService.Play(filePath);
                }
            }
        }

        private void PauseAction()
        {
            if(_isVideoPlayerSelected)
            {
                _videoPlaybackService.Pause();
            }
            else
            {
                _audioPlaybackService.Pause();
            }
        }

        private void StopAction()
        {
            if(_isVideoPlayerSelected)
            {
                _videoPlaybackService.Stop();
            }
            else
            {
                _audioPlaybackService.Stop();
            }
        }

        private void CreatePlaylistAction()
        {
            Console.Write("Enter the playlist name: ");
            string? playlistName = Console.ReadLine();
            if(playlistName != null)
            {
                _playlistService.CreatePlaylist(playlistName);
            }
        }

        private void AddFileToPlaylist()
        {
            Console.Write("Enter the playlist name: ");
            string? playlistName = Console.ReadLine();
            Console.Write("Enter song name: ");
            string? fileName = Console.ReadLine();
            if(playlistName != null)
            {
                _playlistService.AddMediaToPlayList(playlistName, fileName);
            }
        }

        private void RemoveMediaFromPlaylistAction()
        {
            Console.Write("Enter the playlist name: ");
            string? playlistToRemoveFrom = Console.ReadLine();
            Console.Write("Enter the song title to remove: ");
            string? mediaToRemove = Console.ReadLine();
            if(playlistToRemoveFrom != null & mediaToRemove != null)
            {
                _playlistService.RemoveMediaFromPlaylist(playlistToRemoveFrom.ToString(), mediaToRemove.ToString());
            } 
        }
    }
}