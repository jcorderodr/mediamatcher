using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;
using MediaEntities.media.audio;
using MediaInfoLib;
using MediaContract.Media;

namespace Framework.Media
{
    public class MediaTagAudio : MediaTag
    {

        private AudioFile audio;

        public MediaTagAudio(string _path)
            : base(_path)
        {

        }       

        protected override void Init()
        {
            audio = new AudioFile
            {
                Title = FromGeneral("Title"),
                Artist = FromGeneral("Performer"),
                Album = FromGeneral("Album"),

                Genre = FromGeneral("Genre"),
                Year = FromGeneral("Recorded_Date"),
                Composer = FromGeneral("Composer"),

                Format = GetFormat(),
                Size = FromGeneral("FileSize/String3"),
                Path = FromGeneral("CompleteName"),
            };


            audio.Track = TryToInt32(FromGeneral("Track/position"));
            audio.Rating = TryToInt32(FromGeneral("Rating"));
            audio.BitRate = TryToInt32(FromAudio("BitRate")) / 100;
            audio.Channels = TryToInt32(FromAudio("Channel(s)"));
            audio.Duration = TimeSpan.Parse(FromAudio("Duration/String3"));

            //FormatType = AudioFormat.MP3,                
            audio.MediaType = MediaTypes.AUDIO;

            if (FromAudio("Format_Settings_Mode").Contains("stereo")) { audio.Mode = AudioMode.STEREO; }
            else if (FromAudio("Format_Settings_Mode").Contains("mono")) { audio.Mode = AudioMode.MONO; };

            if (FromAudio("cover") == "yes")
            {
                audio.Cover = new Cover { mimeType = FromAudio("Cover_Mime"), Image = FromAudio("Cover_Data") };
            }
        }

    }
}
