using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Common
{
    public class SparkfishList : IList<int>
    {
        private int[] itemList;

        public SparkfishList(int rangeStart, int rangeEnd)
        {
            IList<int> workableList = new List<int>();

            Console.WriteLine($"Generating a list with a range from {rangeStart} to {rangeEnd}");

            int counter = rangeStart;
            int endIndex = rangeEnd - rangeStart;

            for (int i = 0; i < endIndex; i++)
            {
                workableList.Add(counter);
                counter++;
            }

            itemList = workableList.ToArray();

            Console.WriteLine($"List generated with [{itemList.Length}] items");
        }

        public int Count
        {
            get { return itemList.Length; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return itemList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    itemList[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(int item)
        {
            int count = Count;
            Array.Resize(ref itemList, count + 1);
            itemList[count] = item;
        }

        public void Clear()
        {
            itemList = new int[0];
        }

        public bool Contains(int item)
        {
            return Array.IndexOf(itemList, item) != -1;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            Array.Copy(itemList, 0, array, arrayIndex, Count);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)itemList).GetEnumerator();
        }

        public int IndexOf(int item)
        {
            return Array.IndexOf(itemList, item);
        }

        public void Insert(int index, int item)
        {
            int count = Count;
            Array.Resize(ref itemList, count + 1);
            for (int i = count; i > index; i--)
            {
                itemList[i] = itemList[i - 1];
            }
            itemList[index] = item;
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }

            int count = Count;
            for (int i = index; i < count - 1; i++)
            {
                itemList[i] = itemList[i + 1];
            }
            Array.Resize(ref itemList, count - 1);

            return true;
        }

        public void RemoveAt(int index)
        {
            int count = Count;
            for (int i = index; i < count - 1; i++)
            {
                itemList[i] = itemList[i + 1];
            }
            Array.Resize(ref itemList, count - 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return itemList.GetEnumerator();
        }
    }
}