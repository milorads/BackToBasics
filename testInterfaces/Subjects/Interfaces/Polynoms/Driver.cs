//File:Driver.cs

using System.Collections;
using System.Collections.Generic;

namespace Polynomial
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Driver class for the project
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// Times the evaluation of a polynomial
        /// </summary>
        /// <param name="p">The polynomial to evaluate</param>
        public static double TimeEvaluate(Polynomial p)
        {
            var value = 2.0;

            Console.WriteLine("{0}", p.GetType().Name);

            // Time the first iteration. This one is done
            // separately so that we can figure out the startup
            // overhead separately...
            var start = Counter.Value;

            p.Evaluate(0.0);    // do the first iteration.
            var delta = Counter.Value - start;
            Console.WriteLine("Overhead = {0:f2} seconds", (double)delta / Counter.Frequency);
            Console.WriteLine("Eval({0}) = {1}", value, p.Evaluate(value));

            var limit = 100000;
            start = Counter.Value;

            // Evaluate the polynomial the required number of
            // times.
            double result = 0;
            for (var i = 0; i < limit; i++)
            {
                result += p.Evaluate(value);
            }
            delta = Counter.Value - start;

            var ips = (double)limit * ((double)Counter.Frequency / (double)delta);
            Console.WriteLine("Evalutions/Second = {0:f0}", ips);
            Console.WriteLine();

            return (ips);
        }
        /// <summary>
        /// Run all implementations for a given set of coefficients
        /// </summary>
        /// <param name="coeff"> </param>
        public static void Eval(double[] coeff)
        {
            var imps = new Polynomial[]
                {
                    new PolySimple(coeff),
            };

            var results = new double[imps.Length];
            for (var index = 0; index < imps.Length; index++)
            {
                results[index] = TimeEvaluate(imps[index]);
            }

            Console.WriteLine("Results for length = {0}", coeff.Length);
            for (var index = 0; index < imps.Length; index++)
            {
                Console.WriteLine("{0} = {1:f0}", imps[index], results[index]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Testable Eval
        /// </summary>
        /// <param name="coeff"></param>
        public static Hashtable Eval(double[] coeff, bool test)
        {
            var imps = new Polynomial[]
                {
                    new PolySimple(coeff),
            };

            var results = new double[imps.Length];
            for (var index = 0; index < imps.Length; index++)
            {
                results[index] = TimeEvaluate(imps[index]);
            }
            Hashtable outHash = new Hashtable();
            List<string> keys = new List<string>();
            outHash.Add("len", coeff.Length);
            keys.Add("len");
            for (var index = 0; index < imps.Length; index++)
            {
                outHash.Add("imp"+index.ToString(), imps[index]);
                keys.Add("imp" + index.ToString());
                outHash.Add("res" + index.ToString(), results[index]);
                keys.Add("res" + index.ToString());
            }
            outHash.Add("keys", keys);
            return outHash;
        }

        public enum EvalKeys
        {
            len,
        }

        /// <summary>
        /// Main function.
        /// </summary>
        public static void MainPolynoms()
        {
            Eval(new Double[] { 5.5 });

            // Evaluate the first polynomial, with 7 elements
            var coeff =
                new double[] { 5.5, 7.0, 15, 30, 500, 100, 1 };

            Eval(coeff);

            // Evaluate the second polynomial, with 50 elements
            coeff = new double[50];
            for (var index = 0; index < 50; index++)
            {
                coeff[index] = index;
            }
            Eval(coeff);
        }
    }
}