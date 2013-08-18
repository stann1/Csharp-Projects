using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PubnubChat
{
    class Program
    {
        static void Main(string[] args)
        {
            PubnubAPI pubnub = new PubnubAPI(
            "pub-c-143cd1af-de82-4ecc-bfe9-db2904f2d5a4",               // PUBLISH_KEY
            "sub-c-859122ec-07e8-11e3-ba95-02ee2ddab7fe",               // SUBSCRIBE_KEY
            "sec-c-MjBjMTA5NjEtZTI1Mi00ZjgxLWJmZDMtMjU2NTExMjA3Mzkw",   // SECRET_KEY
            true                                                        // SSL_ON?
        );
            string channel = "stan-channel";

            // Publish a sample message to Pubnub
            List<object> publishResult = pubnub.Publish(channel, "Hello Pubnub!");
            Console.WriteLine(
                "Publish Success: " + publishResult[0].ToString() + "\n" +
                "Publish Info: " + publishResult[1]
            );

            // Show PubNub server time
            object serverTime = pubnub.Time();
            Console.WriteLine("Server Time: " + serverTime.ToString());

            // Subscribe for receiving messages (in a background task to avoid blocking)
            System.Threading.Tasks.Task t = new System.Threading.Tasks.Task(
                () =>
                pubnub.Subscribe(
                    channel,
                    delegate(object message)
                    {
                        Console.WriteLine("Received Message -> '" + message + "'");
                        return true;
                    }
                )
            );
            t.Start();

            // Read messages from the console and publish them to Pubnub
            while (true)
            {
                Console.Write("Enter a message to be sent to Pubnub: ");
                string msg = Console.ReadLine();
                pubnub.Publish(channel, msg);
                Console.WriteLine("Message {0} sent.", msg);
            }
        }
    }
}
