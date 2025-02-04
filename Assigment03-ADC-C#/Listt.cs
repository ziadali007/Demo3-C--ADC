using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03_ADC_C_
{
    internal class Listt<T>
    {
        private T[] items;

        private int count;

        public Listt()
        {
            items = new T[4];
            count = 0;
        }

        public Listt(T[] items)
        {

            this.items = items;
            count = items.Length;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                T[] temp = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
            items[count++] = item;
        }

        public bool Exit(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find(Predicate<T> Match)
        {
            for (int i = 0; i < count; i++)
            {
                if (Match(items[i]))
                {
                    return items[i];
                }
            }
            return default(T);
        }

        public Listt<T> FindAll(Predicate<T> Match)
        {
            Listt<T> temp = new Listt<T>();
            for (int i = 0; i < count; i++)
            {
                if (Match(items[i]))
                {
                    temp.Add(items[i]);
                }
            }
            return temp;
        }

        public int FindIndex(T Val)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(Val))
                {
                    return i;
                }
            }
            return -1;
        }

        public T FindLast(Predicate<T> Match)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (Match(items[i]))
                {
                    return items[i];
                }
            }
            return default(T);
        }

        public int FindLastIndex(int start,int end,Predicate<T> Match)
        {
            for (int i = start; i <= end; i++)
            {
                if (Match(items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < count; i++)
            {
                if (!match(items[i]))
                    return false;
            }
            return true;
        }
    }
}
