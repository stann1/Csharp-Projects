using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.TimerWithEvents
{
    class Program
    {
        static void Main(string[] args)
        {            
            Publisher pub = new Publisher();                   //publisher is the class that causes an event at a set interval
            Subscriber sub = new Subscriber();                 //subscriber subcribes to event notifications and prints a message at each event

            pub.TimeInterval = 1000;              //sets the time-interval in ms.
            sub.Subscribe(pub);   

            Console.WriteLine("This event will repeat 20 times");                     
            pub.Start();
        }
    }
}
