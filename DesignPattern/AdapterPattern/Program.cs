// See https://aka.ms/new-console-template for more information
AudioPlayer audioPlayer = new AudioPlayer();
((MediaPlayer)audioPlayer).Play("mp3", "beyond the horizon.mp3");
((MediaPlayer)audioPlayer).Play("mp4", "alone.mp4");
((MediaPlayer)audioPlayer).Play("vlc", "far far away.vlc");
((MediaPlayer)audioPlayer).Play("avi", "mind me.avi");

Console.ReadLine();