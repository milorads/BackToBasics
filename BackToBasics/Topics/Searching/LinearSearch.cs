namespace BackToBasics.Topics.Searching
{
    class LinearSearch
    {
        public int DoSearch(int[] arr, int x)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return i;
            return -1;
        }
    }
}
