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
    }
}
