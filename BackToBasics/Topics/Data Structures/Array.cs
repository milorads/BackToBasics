using System;

namespace BackToBasics.Topics.Data_Structures
{
    class Array
    {
        public int[] DoIterateOneDimensionArray()
        {
            int[] arr = new[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            foreach (var item in arr)
            {
                //only access, no changes
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] += 1;
            }
            return arr;
        }
        //Jagged
        public int[][] DoIterateArrayOfArray()
        {
            int[][] arr = {new[] {1,2,3,4,5}, new[] {6,7,8}};
            var a00 = arr[0][0];//1
            var a01 = arr[0][1];//2
            var a10 = arr[1][0];//6

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] += arr[i][j];
                }
            }
            return arr;
        }
        //Rectangular
        public int[,] DoIterateTwoDimensionArray()
        {
            //all subarrays have to be of same dimension
            int[,] arr = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            var a00 = arr[0,0];//1
            var a01 = arr[0,1];//2
            var a10 = arr[1,0];//6

            for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[i, j] += arr[i, j];
            return arr;
        }

        public int[] DoIterateArrayOfArrayOfArray()
        {
            throw new NotImplementedException();
        }
        public int[] DoIterateThreeDimensionArray()
        {
            throw new NotImplementedException();
        }
    }
}
