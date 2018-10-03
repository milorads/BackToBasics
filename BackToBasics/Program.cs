using BackToBasics.Helpers;
using BackToBasics.Topics.Paradigms.Interfaces.InterfaceTry;
using BackToBasics.Topics.Sorting;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using BackToBasics.Topics.Data_Structures;
using BackToBasics.Topics.Searching;
using Array = BackToBasics.Topics.Data_Structures.Array;

namespace BackToBasics
{
    internal class Program : ProgramExtender
    {
        private static void Main(string[] args)
        {
            var tree = GetTreeNode();//todo: fix not creating right number of items
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
            new LinearSearch().DoSearch(GetUnsortedArray(), 8);
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

        public static int[] GetUnsortedArray(int size = 10, int maxNum = int.MaxValue, int minNum = 0)
        {
            var array = new int[size];
            var r = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = r.Next(minNum, maxNum);
            }
            return array;
        }

        public static int[] GetSortedArray()
        {
            ISort i;
            i = new BubbleSort();
            return i.DoSort(GetUnsortedArray());
        }

        public static BinaryTreeNode GetTreeNode(int number = 5)
        {
            return CreateTreeNode(ref number, new Random());
        }


        private static BinaryTreeNode CreateTreeNode(ref int number, Random r)
        {
            if (number == 0) return null;
            var binTree = new BinaryTreeNode
            {
                Data = r.Next(0, 100),
            };
            if (Randomize(r))
            {
                number=number-1;
                binTree.Left = CreateTreeNode(ref number, r);
            }
            if (Randomize(r))
            {
                number = number - 1;
                binTree.Right = CreateTreeNode(ref number, r);
            }
            if (number > 0 && binTree.Left == null && binTree.Right == null)
            {
                if (Randomize(r))
                {
                    number = number - 1;
                    binTree.Left = CreateTreeNode(ref number, r);
                }
                else
                {
                    number = number - 1;
                    binTree.Right = CreateTreeNode(ref number, r);
                }
            }
            return binTree;
        }

        private static bool Randomize(Random r)
        {
            return r.Next(0, 2) == 0;
        }
    }
}
