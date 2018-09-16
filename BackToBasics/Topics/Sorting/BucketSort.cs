using System.Collections.Generic;

namespace BackToBasics.Topics.Sorting
{
    class BucketSort : ISort
    {
        public int[] DoSort(int[] array)
        {
            return Bucketsort(array);
        }
        public int[] Bucketsort(int[] data)
        {
            var minValue = data[0];
            var maxValue = data[0];

            for (var i = 1; i < data.Length; i++)
            {
                if (data[i] > maxValue)
                    maxValue = data[i];
                if (data[i] < minValue)
                    minValue = data[i];
            }

            var bucket = new List<int>[maxValue - minValue + 1];

            for (var i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            foreach (var currentItem in data)
            {
                bucket[currentItem - minValue].Add(currentItem);
            }

            var k = 0;
            foreach (var currentBucket in bucket)
            {
                if (currentBucket.Count <= 0) continue;
                foreach (var t1 in currentBucket)
                {
                    data[k] = t1;
                    k++;
                }
            }
            return data;
        }
    }
}
