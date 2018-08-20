namespace BackToBasics.Topics.Sorting
{
    public class ShellSort :ISort
    {
        private int[] DoSort(int[] array)
        {
            for (int gap = array.Length/2; gap > 0; gap/=2)
            {
                for (int i = gap; i<array.Length; i++)
                {
                    int temp = array[i];

                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];

                    array[j] = temp;
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
