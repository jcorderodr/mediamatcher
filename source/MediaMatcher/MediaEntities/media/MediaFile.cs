using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaEntities.media
{
   

    public class MediaFile 
    {

        #region Properties

        public MediaTypes MediaType { get; set; }

        public string Path { get; set; }

        public string Name { get; set; }

        public string Format { get; set; }

        /// <summary>
        /// Size in the 1.11 XxX where XxX is the Size type: KB, MiB or GiB.
        /// </summary>
        public string Size { get; set; }

        #endregion

    }
}
