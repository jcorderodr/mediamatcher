using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaContract.Media
{
    public interface IMediaTag<Media> where Media : MediaEntities.media.MediaFile
    {
        String FromGeneral(string _param);
        String FromAudio(string _param);
        String FromVideo(string _param);

        String GetValue(string _tag);
    }
}
