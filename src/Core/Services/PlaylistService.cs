using MediaPlayer.src.Core.Intefaces;

namespace MediaPlayer.src.Core.Services
{
    public class PlaylistService: IPlaylistService
    {
        public void CreatePlaylist(string name)
        {
            Console.WriteLine($"Playlist {name} created");
        }
        public void AddMediaToPlayList(string playlistName, string mediaName)
        {
            Console.WriteLine($"Media {mediaName} added to playlist {playlistName}");
        }
        public void RemoveMediaFromPlaylist(string listName, string mediaName)
        {
            Console.WriteLine($"Media {mediaName} removed from Playlist {listName}");
        }
    }
}