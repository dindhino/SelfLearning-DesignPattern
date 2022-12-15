public class AudioPlayer : MediaPlayer
{
    MediaAdapter mediaAdapter;
    void MediaPlayer.Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "mp3".ToLower())
        {
            Console.WriteLine("Playing MP3 File. Name: " + fileName);
        }
        else if (audioType.ToLower() == "vlc".ToLower() || audioType.ToLower() == "mp4".ToLower())
        {
            mediaAdapter = new MediaAdapter(audioType);
            ((MediaPlayer)mediaAdapter).Play(audioType, fileName);
        }
        else
        {
            Console.WriteLine("Invalid media. " + audioType + " format not supported");
        }
    }
}