using BackToBasics.Helpers;
using BackToBasics.Topics.Paradigms.Interfaces.InterfaceTry;
using BackToBasics.Topics.Sorting;
using System;

namespace BackToBasics
{
    internal class Program : ProgramExtender
    {
        private static void Main(string[] args)
        {
            //todo: rearrange when topics are concluded
            Caller.CallInterfaces();
            Caller.CallKeyValuePair();

            Caller.CallBehavioral();
            Caller.CallCreational();
            Caller.CallStructural();

            //todo: move to caller once written
            ISort sortingAlgorithm = new BubbleSort();
            sortingAlgorithm.DoSort(GetUnsortedArray());
            sortingAlgorithm = new SelectionSort();
            sortingAlgorithm.DoSort(GetUnsortedArray());
            sortingAlgorithm = new InsertionSort();
            sortingAlgorithm.DoSort(GetUnsortedArray());
            sortingAlgorithm = new ShellSort();
            sortingAlgorithm.DoSort(GetUnsortedArray());
            sortingAlgorithm = new QuickSort();
            sortingAlgorithm.DoSort(GetUnsortedArray());
            //sortingAlgorithm = new MergeSort();
            //sortingAlgorithm.DoSort(GetUnsortedArray());
            Console.Read();
        }

        public static int[] GetUnsortedArray()
        {
            return new[] {6, 5, 3, 1, 8, 7, 2, 4};
        }
    }
}
