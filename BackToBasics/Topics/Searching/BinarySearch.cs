namespace BackToBasics.Topics.Searching
{
    class BinarySearch
    {
        public int DoSearch(int[] arr, int x)
        {
            return Binarysearch(arr, 0, arr.Length - 1, x);
        }

        static int Binarysearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the  
                // middle itself 
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then  
                // it can only be present in left subarray 
                if (arr[mid] > x)
                    return Binarysearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                return Binarysearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }
    }
}
