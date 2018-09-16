using BackToBasics.Helpers;
using BackToBasics.Topics.Paradigms.Interfaces.InterfaceTry;
using BackToBasics.Topics.Sorting;
using System;
using System.Collections.Generic;

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
            var sortingAlgorithms = new List<ISort>
            {
                new BubbleSort(), new SelectionSort(),
                new InsertionSort(), new ShellSort(),
                new QuickSort(), new MergeSort(),
                new Topics.Sorting.TimSort(), new HeapSort(),
                /*new TreeSort(),*/ new BucketSort(),
                new RadixSort(), new CountingSort(),
                new BogoSort(), /*new CubeSort()*/

            };
            foreach (var sortingAlgorithm in sortingAlgorithms)
            {
                sortingAlgorithm.DoSort(GetUnsortedArray());
            }
            Console.Read();
        }

        public static int[] GetUnsortedArray()
        {
            return new[] {6, 5, 3, 1, 8, 7, 2, 4};
        }
    }
}
