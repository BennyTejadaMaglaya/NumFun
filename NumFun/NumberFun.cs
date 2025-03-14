namespace NumFun
{
    /// <summary>
    /// Method to determine which number is the biggest
    /// </summary>
    /// <param name="first">First Number</param>
    /// <param name="second">Second Number</param>
    /// <return>Value of the biggest number</return>
    public static class NumberFun
    {
        public static int Biggest(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        /// <summary>
        /// Division method that divides one number by the other
        /// </summary>
        /// <param name="Numerator">Number you are dividing</param>
        /// <param name="Denominator">Value you are dividing by</param>
        /// <return>Result of the division</return>
        /// <exception cref="DivideByZeroException"></exception>
        public static double Division(double Numerator, double Denominator)
        {
            if (Denominator == 0)
            {
                throw new DivideByZeroException("You cannot divide by zero!");
            }
            return Math.Round(Numerator / Denominator, 3);
        }
    }
}
