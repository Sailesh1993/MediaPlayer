namespace MediaPlayer.src.Presentation
{
    internal class Program 
    {
        private static void Main(string[] args)
        {
            MediaPlayerCLI commandLineInterface = new MediaPlayerCLI();
            commandLineInterface.Run();
        }
    }
}
