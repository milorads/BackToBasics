using System;
using System.Collections.Generic;
using System.Linq;

namespace BackToBasics.Topics.Sorting
{
    class BogoSort : ISort
    {
        private List<int> Bogosort(List<int> list)
        {
            var iteration = 0;
            while (!IsSorted(list))
            {
                list = Remap(list);
                iteration++;
            }
            return list;
        }
        private bool IsSorted(List<int> list)
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
        private List<int> Remap(List<int> list)
        {
            var newList = new List<int>();
            var r = new Random();

            while (list.Count > 0)
            {
                var temp = r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }
            return newList;
        }

        public int[] DoSort(int[] array)
        {
            return Bogosort(array.ToList()).ToArray();
        }
    }
}