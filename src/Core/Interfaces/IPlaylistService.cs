namespace MediaPlayer.src.Core.Intefaces
{
    public interface IPlaylistService
    {
        void CreatePlaylist (string name);
        void AddMediaToPlayList(string playlistName, string mediaName);
        void RemoveMediaFromPlaylist(string listNmae, string mediaName);
    }
}