namespace MediaPlayer.src.Presentation
{
    public class ErrorHandler
    {
        public static void HandleError (Exception e)
        {
            Console.WriteLine($"Error occured: {e.Message}");
        }
    }
}