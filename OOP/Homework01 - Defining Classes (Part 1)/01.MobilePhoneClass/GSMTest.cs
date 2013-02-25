using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class GSMTest                                 
    {
        static void Main(string[] args)            //task 7, uncomment to test
        {
            Battery newBattery = new Battery("VPower", 66, 12, BatteryType.NiMH);
            Display newDisplay = new Display(4.7, 13000000);


            //Initialize without battery and display
            GSM myPhone = new GSM("Nokia", "Lumia 8", "Jack", 699.89);
            Console.WriteLine(myPhone);

            //Initialize with battery and display
            GSM mySecondPhone = new GSM("Nokia", "Lumia 8", "Jack", 699.89, newBattery, newDisplay);
            Console.WriteLine(mySecondPhone);

            //Initialize with manufacturer and model only
            GSM myThirdPhone = new GSM("Sony", "Xperia 10");
            Console.WriteLine(myThirdPhone);

            //Initialize IPhone 4s:
            GSM iphone = new GSM("Apple", "Iphone");
            Console.WriteLine(iphone.IPhone4s);


        }
    }
}
