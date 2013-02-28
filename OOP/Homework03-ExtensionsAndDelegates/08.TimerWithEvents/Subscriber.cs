﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.TimerWithEvents
{
    class Subscriber
    {
        public void Subscribe(Publisher pub)
        {
            pub.RaiseCustomEvent += new Publisher.TimerDelegate(Message);               //the event is attached to the delegate
        }

        public void Message(Publisher pub, EventArgs e)
        {
            Console.WriteLine("You have a new message");
        }
    }
}
