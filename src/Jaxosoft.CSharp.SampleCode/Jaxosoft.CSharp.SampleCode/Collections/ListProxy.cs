using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Jaxosoft.CSharp.SampleCode.Collections
{
    /// <summary>
    /// This class allows you to create an IList&lt;T&gt; that is
    /// in actuality, comprised of multiple IList&lt;T&gt;s.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListProxy<T> : IList<T>
    {
        private IList<IList<T>> _lists;

        #region .ctors
        public ListProxy()
        {
            _lists = new List<IList<T>>();
        }

        public ListProxy(int capacity)
        {
            _lists = new List<IList<T>>(capacity);
        }

        public ListProxy(IEnumerable<T> collection) : this()
        {
            _lists.Add(collection.ToList());
        }
        #endregion

        #region IList<T> members
        public T this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    int currOffset = 0;
                    foreach (var list in _lists)
                    {
                        if (index < currOffset + list.Count)
                        {
                            return list[index - currOffset];
                        }
                        currOffset += list.Count;
                    }
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0)
                {
                    int currOffset = 0;
                    foreach (var list in _lists)
                    {
                        if (index < currOffset + list.Count)
                        {
                            list[index - currOffset] = value;
                            break;
                        }
                        currOffset += list.Count;
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (var list in _lists)
                    count += list.Count;
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException();

            if (_lists.Count == 0)
            {
                _lists.Add(new List<T> { item });
            }
            else
            {
                _lists[_lists.Count - 1].Add(item);
            }
        }

        public void Clear()
        {
            foreach (var list in _lists)
            {
                list.Clear();
            }
            _lists.Clear();
        }

        public bool Contains(T item)
        {
            if (item == null)
                throw new ArgumentNullException();

            foreach (var list in _lists)
            {
                if (list.Contains(item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var list in _lists)
                foreach (var item in list)
                    yield return item;
        }

        public int IndexOf(T item)
        {
            int offset = 0;
            foreach (var list in _lists)
            {
                int indexOf = list.IndexOf(item);
                if (indexOf != -1)
                    return indexOf + offset;
                offset += list.Count;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index >= 0)
            {
                int currOffset = 0;
                foreach (var list in _lists)
                {
                    if (index < currOffset + list.Count)
                    {
                        list.Insert(index - currOffset, item);
                        return;
                    }
                    currOffset += list.Count;
                }
            }
            throw new IndexOutOfRangeException();
        }

        public bool Remove(T item)
        {
            foreach (var list in _lists)
            {
                if (list.Remove(item))
                    return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0)
            {
                int currOffset = 0;
                foreach (var list in _lists)
                {
                    if (index < currOffset + list.Count)
                    {
                        list.RemoveAt(index - currOffset);
                        return;
                    }
                    currOffset += list.Count;
                }
            }
            throw new IndexOutOfRangeException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region here be dragons... use at your own peril!
        public IList<IList<T>> InternalLists
        {
            get { return _lists; }
        }
        #endregion
    }
}
