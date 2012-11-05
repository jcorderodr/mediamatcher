using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;
using MediaEntities.media.audio;
using MediaInfoLib;

namespace Framework.Media
{
    public class MediaPlayer : MediaContract.Media.PlayerBase
    {

        private AudioFile _file;
        private List<AudioFile> files;

        #region Properties

        public List<AudioFile> Files { get { return files; } }

        #endregion

        public MediaPlayer(string _path)
        {
        }

        public MediaPlayer(MediaFile file)
        {
            throw new NotImplementedException();
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void Pause()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

    }
}
