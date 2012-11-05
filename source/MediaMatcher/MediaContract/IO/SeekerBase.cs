using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;

namespace MediaContract.IO
{
    public abstract class SeekerBase
    {

        public abstract string[,] DuplicateFiles(string _path);
                

        public abstract List<MediaFile> RipForMedia(MediaTypes lookFor, string _path);

        public abstract void CompareFolders(params string[] _folders);

        public abstract string RipFolder(string _path);
    }
}
