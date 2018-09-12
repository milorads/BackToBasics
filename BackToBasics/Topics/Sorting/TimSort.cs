//All credits go to: http://www.java2s.com/Open-Source/CSharp_Free_Code/Algorithm/Download_TimSort_for_NET.htm

using System.Linq;


namespace BackToBasics.Topics.Sorting
{
    public class TimSort : ISort
    {
        public int[] DoSort(int[] array)
        {
            array.TimSort();
            return array;
        }
    }
}
