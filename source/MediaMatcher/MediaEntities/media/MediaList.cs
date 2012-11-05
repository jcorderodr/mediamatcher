using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaEntities.media
{
    public class MediaList : IList<MediaFile>
    {

        public MediaList()
        {
            
        }

        #region IList Members

        public int IndexOf(MediaFile item)
        {
            return this.IndexOf(item);
        }

        public void Insert(int index, MediaFile item)
        {
            this.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.RemoveAt(index);
        }

        public MediaFile this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = value;
            }
        }

        #endregion

        #region ICollection<AudioFile> Members

        public void Add(MediaFile item)
        {
            this.Add(item);
        }

        public void Clear()
        {
            this.Clear();
        }

        public bool Contains(MediaFile item)
        {
            return this.Contains(item);
        }

        public void CopyTo(MediaFile[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return this.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(MediaFile item)
        {
            return this.Remove(item);
        }

        #endregion

        #region IEnumerable<AudioFile> Members

        public IEnumerator<MediaFile> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
