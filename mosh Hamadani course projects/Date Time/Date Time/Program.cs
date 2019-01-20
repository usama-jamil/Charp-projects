using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var DateTime = new DateTime();
            //Console.WriteLine(DateTime.DaysInMonth(1998, 1));
            var timeSpan = TimeSpan.TicksPerSecond;
            var timeSpan2 = new TimeSpan(9,1,4,0,0);
            var time = DateTime.Now;
            Thread.Sleep(1000);
            obj
            var interval = DateTime.Now;

            var duration = interval - time;
            
            Console.WriteLine(duration);
            Console.ReadKey();
        }
    }
}
