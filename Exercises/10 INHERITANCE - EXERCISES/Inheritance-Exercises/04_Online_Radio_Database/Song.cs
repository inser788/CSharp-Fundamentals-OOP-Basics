using System;

public class Song
{
    private const int minArtistNameLength = 3;
    private const int maxArtistNameLength = 20;
    private const int minSongNameLength = 3;
    private const int maxSongNameLength = 30;
    private const int minMinutes = 0;
    private const int maxMinutes = 14;
    private const int minSeconds = 0;
    private const int maxSeconds = 59;


    private string artist;
    private string name;
    private int minutesDuration;
    private int secondsDuration;
    private long totalDurationSeconds;

    public Song(string artist, string name, int minutesDuration, int secondsDuration)
    {
        Artist = artist;
        Name = name;
        MinutesDuration = minutesDuration;
        SecondsDuration = secondsDuration;
    }

    public string Artist
    {
        get => artist;
        set
        {
            if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            if (value.Length<minArtistNameLength||value.Length>maxArtistNameLength)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }

            this.artist = value;
        }
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            if (value.Length < minSongNameLength || value.Length > maxSongNameLength)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }

            this.name = value;
        }
    }

    public int MinutesDuration
    {
        get => minutesDuration;
        set
        {
            if (value<minMinutes||value>maxMinutes)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }

            this.minutesDuration = value;
        }
    }

    public int SecondsDuration
    {
        get => secondsDuration;
        set
        {
            if (value<minSeconds||value>maxSeconds)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }

            this.secondsDuration = value;
        }
    }

    public long TotalDurationSeconds
    {
        get => totalDurationSeconds = this.MinutesDuration * 60 + this.SecondsDuration;
    }
}

