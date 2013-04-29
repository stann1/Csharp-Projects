using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Timer
{
    class Timer
    {
        public delegate void TimerDelegate(string param);
        public static int messageCounter = 0;

        public static void ShowMessage(string message)
        {
            Console.WriteLine("Question: " + message);
        }

        public void PrintCounter(string message)
        {
            Console.WriteLine("I repeat {0}, {1} times", message, messageCounter);
        }
    }
}
