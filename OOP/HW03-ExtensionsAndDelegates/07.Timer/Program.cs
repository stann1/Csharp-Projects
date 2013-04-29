using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _07.Timer
{
       

    class Program
    {        

        static void Main(string[] args)
        {           
            DateTime start = DateTime.Now;          
            DateTime now = start.AddSeconds(2);              //sets the time interval in seconds (can be changed)
            var t = now - start;

            Timer.TimerDelegate d = Timer.ShowMessage;                 //declaring multicast delegate
            d += new Timer().PrintCounter;

            Console.WriteLine("This message will repeat until the count reaches 20");
            while (Timer.messageCounter < 20)
            {
                d("I can haz cheezburger?");
                Timer.messageCounter++;
                Thread.Sleep(t);
            }
        }
    }
}
