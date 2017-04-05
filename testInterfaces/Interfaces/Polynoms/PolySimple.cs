namespace Polynomial
{
    using System;
    /// <summary>
    /// The simplest polynomial implementation
    /// </summary>
    /// <description>
    /// This implementation loops through the coefficients and evaluates each
    /// term of the polynomial.
    /// </description>
    class PolySimple : Polynomial
    {
        public PolySimple(params double[] coefficients) : base(coefficients)
        {
        }

        public override double Evaluate(double value)
        {
            var retval = coefficients[0];

            var f = value;

            for (var i = 1; i < coefficients.Length; i++)
            {
                retval += coefficients[i] * f;
                f *= value;
            }
            return (retval);
        }
    }
}