using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaEntities.media.audio
{
    public class AudioFile : MediaFile
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Track { get; set; }
        public string Year { get; set; }
        public string Composer { get; set; }
        public int Rating { get; set; }
        //public string Accompaniment { get; set; }
       
        public TimeSpan Duration { get; set; }
        public string Genre { get; set; }
        public AudioFormat FormatType { get; set; }
        public AudioMode Mode { get; set; }
        public int BitRate { get; set; }
        //public MediaFile MediaFile { get; set; }
        public int Channels { get; set; }
        public Cover Cover { get; set; }

        ~AudioFile()
        {
        }

    }

    public class Cover
    {
        public string mimeType { get; set; }
        public string Image { get; set; }
    }

    public enum AudioFormat
    {
        AMW,
        FLAC,
        MP3,
        MP2,
        OGG,
        WAV
    }

    public enum AudioMode
    {
        MONO,
        STEREO,
    }
}
