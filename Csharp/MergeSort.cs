using System;

namespace Csharp
{
    public class MergeSort
    {
        public MergeSort(int size = 10)
        { // List<> left median()
            int[] freq = new int[size];
            int startindex = 0;
            int endindex = 0;
            int[] list = Run(freq, startindex, endindex);
        }
        int[] Run(int[] _freq, double startindex, double endindex)
        {
            if (startindex > endindex)
            {
                double divid = (startindex + endindex) / 2;
                double middle = Math.Floor(divid);
                Run(_freq, startindex, middle);
                Run(_freq, middle + 1, endindex);
                return merge(_freq, startindex, endindex, middle);
            }
            return _freq;
        }

        int[] merge(int[] a, double b, double c, double d)
        {
            return a;
        }
    }
}