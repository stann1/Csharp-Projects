using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    class GSM
    {
        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private string owner;
        private double price;

        internal List<Call> callHistory = new List<Call>();      //task 9

        //static fields for the IPhone 4s: (task 6)
        private static Battery battery4S = new Battery("AppleTech", 168, 16, BatteryType.LiIon);
        private static Display display4S = new Display(5.1, 16000000);
        private static GSM iPhone4S = new GSM("Apple", "IPhone 4s", "Gancho", 899.99, battery4S, display4S);

        //Property fields        
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public double Price
        {
            get { return this.price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price cannot be negative!");
                }
                this.price = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public GSM IPhone4s { get { return iPhone4S; } }               
      
        
       
        //Constructors        

        public GSM(string manufacturer, string model, string owner, double price, Battery battery, Display display)  //full
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Owner = owner;
            this.Price = price;
            this.Battery = battery;
            this.display = display;
        }

        public GSM(string manufacturer, string model) : this (manufacturer, model, null, 0, null, null)  //manuf. and model only
        {            
        }

        public GSM(string manufacturer, string model, string owner, double price)       //full, except battery and display
            : this(manufacturer, model, owner, price, null, null)
        {
        }
        
        //Methods
        public override string ToString()                //overriding ToString to display specific information (task 4)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Phone information:");
            sb.AppendLine(this.manufacturer);
            sb.AppendLine(this.model);
            sb.AppendLine("Owner: " + this.owner);
            sb.AppendLine("Price: " + this.price);
            if (this.battery != null)
            {
                sb.AppendLine("Battery information:");
                sb.AppendLine("Model: " + this.Battery.BatteryModel);
                sb.AppendLine("Type: " + this.Battery.Type);
                sb.AppendLine("Idle hours: " + this.Battery.HoursIdle);
                sb.AppendLine("Talk hours: " + this.Battery.HoursTalk);
            }
            if (this.display != null)
            {
                sb.AppendLine("Display information:");
                sb.AppendLine("Screen size: " + this.Display.Size);
                sb.AppendLine("Colors: " + this.Display.ColorsCount);
            }
            

            return sb.ToString();
        }

        public void AddCall(string phoneNumber, int duration)            //method for adding calls (task 10)
        {
            Call newCall = new Call(phoneNumber, duration);
            callHistory.Add(newCall);
        }

        public void RemoveCall(string phoneNumber)            //method for deleting calls (task 10)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].PhoneNumber == phoneNumber)
                {
                    callHistory.RemoveAt(i);
                }
            }            
        }

        public void RemoveCallAtMaxDuration()
        {
            int maxDuration = 0;
            int position = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration > maxDuration)
                {
                    maxDuration = callHistory[i].Duration;
                    position = i;
                }
            }

            callHistory.RemoveAt(position);
        }

        public void ClearCallHistory()                   //clearing the whole history
        {
            callHistory.Clear();
        }

       

        public void CalculateBill(double pricePerMinute = 0.37)             //calculate total price (task 11)
        {
            int totalDuration = 0;            //in seconds

            for (int i = 0; i < callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }

            double bill = (totalDuration / 60.0) * pricePerMinute;
            Console.WriteLine("The total bill for {0:F2} minutes is {1:F2}lv.", (totalDuration / 60.0), bill);
        }

        
    }
}
