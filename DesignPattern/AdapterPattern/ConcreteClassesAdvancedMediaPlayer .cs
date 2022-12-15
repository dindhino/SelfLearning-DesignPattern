public class VLCPlayer : AdvancedMediaPlayer
{
    void AdvancedMediaPlayer.PlayMP4(string fileName)
    {
    }

    void AdvancedMediaPlayer.PlayVLC(string fileName)
    {
        Console.WriteLine("Playing VLC File. Name: " + fileName);
    }
}

public class MP4Player : AdvancedMediaPlayer
{
    void AdvancedMediaPlayer.PlayMP4(string fileName)
    {
        Console.WriteLine("Playing MP4 File. Name: " + fileName);
    }

    void AdvancedMediaPlayer.PlayVLC(string fileName)
    {
        throw new NotImplementedException();
    }
}
