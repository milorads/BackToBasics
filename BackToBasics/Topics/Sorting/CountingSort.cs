namespace BackToBasics.Topics.Sorting
{
    class CountingSort : ISort
    {
        public int[] DoSort(int[] array)
        {
            return Countingsort(array);
        }

        public int[] Countingsort(int[] array)
        {
            var sortedArray = new int[array.Length];

            var minVal = array[0];
            var maxVal = array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            var counts = new int[maxVal - minVal + 1];

            foreach (var item in array)
            {
                counts[item - minVal]++;
            }

            counts[0]--;
            for (var i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (var i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
        }
    }
}
