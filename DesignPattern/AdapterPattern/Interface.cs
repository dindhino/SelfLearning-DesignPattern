public interface MediaPlayer
{
    public void Play(string audioType, string fileName);
}

public interface AdvancedMediaPlayer
{
    public void PlayVLC(string fileName);
    public void PlayMP4(string fileName);
}