using System;
using System.Threading;

namespace Csharp
{
    public class Time
    {
        void Timer(int interval = 300)
        {
            int sec = 300;
            while (true)
            {
                for (int i = sec; i >= 0; i--)
                {
                    int minute = i / 60;
                    int second = i % 60;//i - minute * 60
                    Console.WriteLine("{0}:{1}", minute, second.ToString("D2")); Thread.Sleep(100);
                }
                sec = interval;
            }
        }
    }
}