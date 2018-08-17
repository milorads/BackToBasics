namespace BackToBasics.Topics.Paradigms.Interfaces.Polynoms
{
    class Counter
    {
        public static long Frequency
        {
            get
            {
                long freq = 0;
                QueryPerformanceFrequency(ref freq);
                return freq;
            }
        }
        public static long Value
        {
            get
            {
                long count = 0;
                QueryPerformanceCounter(ref count);
                return count;
            }
        }

        [System.Runtime.InteropServices.DllImport("KERNEL32")]
        private static extern bool QueryPerformanceCounter(ref long lpPerformanceCount);

        [System.Runtime.InteropServices.DllImport("KERNEL32")]
        private static extern bool QueryPerformanceFrequency(ref long lpFrequency);
    }
}
