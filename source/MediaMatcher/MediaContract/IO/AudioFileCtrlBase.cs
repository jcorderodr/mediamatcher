using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;

namespace MediaContract.IO
{
    public abstract class AudioFileCtrlBase
    {

        public abstract void CreateMediaDirectory(string root);
        public abstract void CreateMediaDirectory(string root, int categoryToUse);

        public abstract void CreateMediaList(MediaList list, string _path);
        public abstract void CreateMediaList(MediaList list, string _path, MediaListType listType);

        public abstract MediaList Load(string _path);

        public abstract bool CopyMediaList(MediaList list, string _path);

    }
}
