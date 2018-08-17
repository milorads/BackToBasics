using BackToBasics.Topics.Design_Patterns.Behavioral.Strategy;
using NUnit.Framework;

namespace BackToBasics.Tests.Design_Patterns.Behavioral
{
    class StrategyTests
    {
        [Test]
        public static void TestStrategies()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            StringAssert.AreEqualIgnoringCase(context.ContextInterface(true), "Called ConcreteStrategyA.AlgorithmInterface()");

            context = new Context(new ConcreteStrategyB());
            StringAssert.AreEqualIgnoringCase(context.ContextInterface(true), "Called ConcreteStrategyB.AlgorithmInterface()");

            context = new Context(new ConcreteStrategyC());
            StringAssert.AreEqualIgnoringCase(context.ContextInterface(true), "Called ConcreteStrategyC.AlgorithmInterface()");
        }
        [Test]
        public static void TestSorts()
        {
            var studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            StringAssert.AreEqualIgnoringCase(studentRecords.Sort(true), "QuickSorted list");

            studentRecords.SetSortStrategy(new ShellSort());
            StringAssert.AreEqualIgnoringCase(studentRecords.Sort(true), "ShellSorted list");

            studentRecords.SetSortStrategy(new MergeSort());
            StringAssert.AreEqualIgnoringCase(studentRecords.Sort(true), "MergeSorted list");
        }
    }
}
