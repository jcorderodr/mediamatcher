using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;
using MediaEntities.media.audio;
using MediaInfoLib;
using MediaContract.Media;

namespace Framework
{
    public abstract class MediaTag : IMediaTag<AudioFile>, IDisposable
    {
        protected MediaInfo mi;

        public MediaTag(string _file)
        {
            mi = new MediaInfo();

            if (System.IO.File.Exists(_file))
            {
                int r = mi.Open(_file);
            }
            else
            {
                throw new System.IO.FileNotFoundException("El archivo indicado no existe.", _file);
            }

            Init();
        }

        void IDisposable.Dispose()
        {
            mi.Close();
        }


        protected abstract void Init();

        internal int TryToInt32(string _string)
        {
            try
            {
                return Convert.ToInt32(_string);
            }
            catch (FormatException ex)
            {
                return -1;
            }
        }

        internal DateTime? TryToDate(string _string)
        {
            try
            {
                return Convert.ToDateTime(_string);
            }
            catch (FormatException ex)
            {
                return null;
            }
        }

        public String FromGeneral(string _param)
        {
            return mi.Get(StreamKind.General, 0, _param);
        }

        public String FromAudio(string _param)
        {
            return mi.Get(StreamKind.Audio, 0, _param);
        }

        public String FromVideo(string _param)
        {
            return mi.Get(StreamKind.Video, 0, _param);
        }

        public string GetFormat()
        {
            return mi.Get(StreamKind.General, 0, "Format"); ;
        }

        protected internal string Custom_Option(StreamKind streamKind, string param)
        {
            return mi.Get(streamKind, 0, param);
        }

        public string GetValue(string _tag)
        {
            throw new NotImplementedException();
        }
    }
}
