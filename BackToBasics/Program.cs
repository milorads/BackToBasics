using BackToBasics.Helpers;
using BackToBasics.Topics.Paradigms.Interfaces.InterfaceTry;
using BackToBasics.Topics.Sorting;
using System;
using System.Collections.Generic;
using BackToBasics.Topics.Data_Structures;
using BackToBasics.Topics.Searching;
using Array = BackToBasics.Topics.Data_Structures.Array;

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

            //todo: move to caller at some point
            new DepthFirstSearch(GetTreeNode()).DoSearch(8);
            new BreadthFirstSearch(GetTreeNode()).DoSearch(8);
            new LinearSearch().DoSearch(GetUnsortedArray(),8);
            new BinarySearch().DoSearch(GetUnsortedArray(), 8);
            new ExponentialSearch().DoSearch(GetUnsortedArray(), 8);
            new JumpSearch().DoSearch(GetUnsortedArray(), 8);
            new FibonacciSeearch().DoSearch(GetUnsortedArray(), 8);
            new InterpolationSearch().DoSearch(GetUnsortedArray(), 8);

            new Array().DoIterateOneDimensionArray();
            new Array().DoIterateArrayOfArray();
            new Array().DoIterateTwoDimensionArray();

            new Stack().StackOperations();

            new Queue().QueueOperations();

            Console.WriteLine("---DONE---");
            Console.Read();
        }

        public static int[] GetUnsortedArray()
        {
            //todo rework to randomize
            return new[] {6, 5, 3, 1, 8, 7, 2, 4};
        }

        public static int[] GetSortedArray()
        {
            ISort i;
            i = new BubbleSort();
            return i.DoSort(GetUnsortedArray());
        }

        public static BinaryTreeNode GetTreeNode()
        {
            //todo rework to randomize, accept number of elements
            return new BinaryTreeNode()
            {
                Data = 6,
                Left = new BinaryTreeNode()
                {
                    Data = 5,
                    Right = new BinaryTreeNode()
                    {
                        Data = 1,
                        Right = new BinaryTreeNode() { Data = 2, Right = null, Left = null },
                        Left = null
                    },
                    Left = new BinaryTreeNode()
                    {
                        Data = 8,
                        Right = null,
                        Left = new BinaryTreeNode() { Data = 18, Right = null,Left = null}
                    }
                },
                Right = new BinaryTreeNode()
                {
                    Data = 3,
                    Right = new BinaryTreeNode()
                    {
                        Data = 17,
                        Right = new BinaryTreeNode() { Data = 33, Right = new BinaryTreeNode() { Data =2, Right = null, Left = null }, Left = null },
                        Left = null
                    },
                    Left = new BinaryTreeNode()
                    {
                        Data = 90,
                        Right = null,
                        Left = new BinaryTreeNode() { Data = 8, Right = null, Left = new BinaryTreeNode() { Data = 78, Right = null, Left = null } }
                    }
                }
            };
        }
    }
}
