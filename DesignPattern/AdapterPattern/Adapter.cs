public class MediaAdapter : MediaPlayer
{
    AdvancedMediaPlayer advancedMediaPlayer;

    public MediaAdapter(string audioType)
    {
        if (audioType.ToLower() == "vlc".ToLower())
        {
            advancedMediaPlayer = new VLCPlayer();

        }
        else if (audioType.ToLower() == "mp4".ToLower())
        {
            advancedMediaPlayer = new MP4Player();
        }
    }

    void MediaPlayer.Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "vlc".ToLower())
        {
            advancedMediaPlayer.PlayVLC(fileName);
        }
        else if (audioType.ToLower() == "mp4".ToLower())
        {
            advancedMediaPlayer.PlayMP4(fileName);
        }
    }
}
