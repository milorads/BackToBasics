namespace BackToBasics.Topics.Sorting
{
    public class SelectionSort : ISort
    {
        private int[] DoSort(int[] array)
        {
            for (int j = 0; j < array.Length-1; j++)
            {
                int iMin = j;
                for (int i = j+1; i < array.Length; i++)
                {
                    if (array[i] < array[iMin])
                    {
                        iMin = i;
                    }
                }
                if (iMin == j) continue;
                int temp = array[j];
                array[j] = array[iMin];
                array[iMin] = temp;
            }

            return array;
        }

        int[] ISort.DoSort(int[] array)
        {
            return DoSort(array);
        }
    }
}
