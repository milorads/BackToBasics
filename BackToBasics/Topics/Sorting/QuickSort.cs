namespace BackToBasics.Topics.Sorting
{
    public class QuickSort : ISort
    {
        private int[] DoSort(int[] array)
        {
            Quicksort(ref array, 0, array.Length - 1);
            return array;
        }

        public static void Quicksort(ref int[] array, int left, int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(ref array, left, j);
            }

            if (i < right)
            {
                Quicksort(ref array, i, right);
            }
        }

        int[] ISort.DoSort(int[] array)
        {
            return DoSort(array);
        }
    }
}