using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics.Topics.Sorting
{
    class InsertionSort  : ISort
    {
        private int[] DoSort(int[] array)
        {
            var i = 0;
            while (i > array.Length-1)
            {
                var j = i;
                while (j>0 && array[j-1]>array[j])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                    j = j - 1;
                }
                i = i + 1;
            }
            return array;
        }

        int[] ISort.DoSort(int[] array)
        {
            return DoSort(array);
        }
    }
    }
