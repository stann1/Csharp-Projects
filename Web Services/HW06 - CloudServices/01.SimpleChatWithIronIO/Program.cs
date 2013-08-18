using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using io.iron.ironmq;
using io.iron.ironmq.Data;

namespace _01.SimpleChatWithIronIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(
            "520a43c24ce3460009000006",
            "TWlNAHfIkmuTc-WPS32NeC9tm6c");
            Queue queue = client.queue("StanChatQueue");
            Console.WriteLine("Listening for new messages from IronMQ server:");
            while (true)
            {
                Message msg = queue.get();
                if (msg != null)
                {
                    Console.WriteLine(msg.Body);
                    queue.deleteMessage(msg);
                }
                if (Console.KeyAvailable)
                {
                    string typedMsg = Console.ReadLine();
                    queue.push(typedMsg);
                }
                Thread.Sleep(100);
            }
        }
    }
}
