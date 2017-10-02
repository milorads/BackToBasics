using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace testInterfaces.Design_Patterns.Behavioral
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

        private bool Contains(string input)
        {
            if (input.Contains("Called Terminal.Interpret()") || input.Contains("Called Nonterminal.Interpret()"))
            {
                return true;
            }
            return false;
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

            Console.WriteLine("{0} = {1}",
                roman, contextImplementation.Output);
        }
    }
}
