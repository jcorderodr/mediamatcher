using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaEntities.media;

namespace MediaEntities.IO
{
    public interface ICustomSeek : ISeek
    {
        MediaList Exec();

        void Create();
        void Save();

        void setDisplayMethod(string format);

    }
}
