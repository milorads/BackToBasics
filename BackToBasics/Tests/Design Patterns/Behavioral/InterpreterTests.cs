using BackToBasics.Topics.Design_Patterns.Behavioral.Interpreter;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace BackToBasics.Tests.Design_Patterns.Behavioral
{
    [TestFixture]
    class InterpreterTests
    {
        [Test]
        public void TestInterpreterSample()
        {
            InterpreterContext context = new InterpreterContext();

            ArrayList list = new ArrayList
            {
                new TerminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression(),
                new TerminalExpression()
            };

            foreach (AbstractExpression exp in list)
            {
                var returnValue = exp.Interpret(context, true);
                Assert.IsTrue(Contains(returnValue));
            }
        }

        private static bool Contains(string input)
        {
            return input.Contains("Called Terminal.Interpret()") || input.Contains("Called Nonterminal.Interpret()");
        }

        [Test]
        public void TestInterpreterYearConversion()
        {
            string roman = "MCMXXVIII";
            InterpreterApplicationContext contextImplementation = new InterpreterApplicationContext(roman);

            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression exp in tree)
            {
                exp.Interpret(contextImplementation);
            }

            StringAssert.AreEqualIgnoringCase(roman, "MCMXXVIII");
            Assert.AreEqual(contextImplementation.Output, 1928);
        }
    }
}
