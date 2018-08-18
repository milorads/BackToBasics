namespace BackToBasics.Topics.Sorting
{
    public class BubbleSort : ISort
    {
        private int[] DoSort(int[] array)
        {
            var swap = true;
            while (swap)
            {
                swap = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (i + 1 <= array.Length && array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        swap = true;
                    }
                }
            }
            return array;
        }

        int[] ISort.DoSort(int[] array)
        {
            return DoSort(array);
        }
    }
}
