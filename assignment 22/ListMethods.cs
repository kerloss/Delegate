using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    internal class ListMethods<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();
        public bool Exist(T item)
        {
            return items.Contains(item);
        }

        public T Find(Predicate<T> match)
        {
            return items.Find(match);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            return items.FindAll(match);
        }

        public int FindIndex(Predicate<T> match)
        {
            return items.FindIndex(match);
        }

        public T FindLast(Predicate<T> match)
        {
            return items.FindLast(match);
        }

        public int FindLastIndex(Predicate<T> match)
        {
            return items.FindLastIndex(match);
        }

        public void ForEach(Action<T> action)
        {
            items.ForEach(action);
        }

        public bool TrueForAll(Predicate<T> match)
        {
            return items.TrueForAll(match);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
