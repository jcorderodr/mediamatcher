using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;
using MediaEntities.media.audio;

namespace MediaContract.Media
{
    public abstract class PlayerBase
    {
       
        //public abstract void AudioFile(string _path);
        //public abstract void AudioFile(MediaFile file);

        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();


    }
}
