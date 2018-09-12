namespace BackToBasics.Topics.Sorting
{
    public class MergeSort : ISort
    {
        private int[] DoSort(int[] array)
        {
            return Mergesort(array, 0, array.Length - 1);
        }

        private int[] Mergesort(int[] array, int start, int end)
        {
            if (start < end)
            {
                var middle = (end + start) / 2;
                var leftArr = Mergesort(array, start, middle);
                var rightArr = Mergesort(array, middle + 1, end);
                var mergedArr = MergeArray(leftArr, rightArr);
                return mergedArr;
            }
            return new[] { array[start] };
        }

        private static int[] MergeArray(int[] leftArr, int[] rightArr)
        {
            int[] mergedArr = new int[leftArr.Length + rightArr.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;

            // Traverse both arrays simultaneously and store the smallest element of both to mergedArr
            while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                if (leftArr[leftIndex] < rightArr[rightIndex])
                {
                    mergedArr[mergedIndex++] = leftArr[leftIndex++];
                }
                else
                {
                    mergedArr[mergedIndex++] = rightArr[rightIndex++];
                }
            }

            // If any elements remain in the left array, append them to mergedArr
            while (leftIndex < leftArr.Length)
            {
                mergedArr[mergedIndex++] = leftArr[leftIndex++];
            }

            // If any elements remain in the right array, append them to mergedArr
            while (rightIndex < rightArr.Length)
            {
                mergedArr[mergedIndex++] = rightArr[rightIndex++];
            }

            return mergedArr;
        }


        int[] ISort.DoSort(int[] array)
        {
            return DoSort(array);
        }
    }
}