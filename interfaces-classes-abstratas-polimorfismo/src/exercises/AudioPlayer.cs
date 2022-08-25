namespace inter;
public class AudioPlayer
{
    public IPlayer Player { get; set; }

    public void MusicPlayer(IPlayer player)
    {
        Player = player;
    }

	public void PlaySong(string songName)
	{
	    Player.Play(songName);
	}

	public void PlayPodcast(string podcastName)
	{
	    Player.Play(podcastName);
	}
}