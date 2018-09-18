using System;

namespace BackToBasics.Topics.Searching
{
    class JumpSearch
    {
        public int DoSearch(int[] arr, int x)
        {
            return Jumpsearch(arr, x);
        }

        public static int Jumpsearch(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where element is
            // present (if it is present)
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block
            // beginning with prev.
            while (arr[prev] < x)
            {
                prev++;

                // If we reached next block or end of
                // array, element is not present.
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}
