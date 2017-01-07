using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace timerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimers = new Timer(2000);
            myTimers.Elapsed += myTimer_Elapsed;
            myTimers.Elapsed += myTimer_Elapsed1;

            myTimers.Start();
            Console.ReadLine();

            myTimers.Elapsed -= myTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void myTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed : {0:HH:MM:ss.fff}", e.SignalTime);
        }

        private static void myTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed : {0:HH:MM:ss.fff}", e.SignalTime);
        }
    }
}
