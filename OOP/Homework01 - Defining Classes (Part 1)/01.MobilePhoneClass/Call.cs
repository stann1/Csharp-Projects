using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.MobilePhoneClass
{
    class Call                                //task 8
    {
        private DateTime callDateTime;        
        private string phoneNumber;
        private int duration;
        private DateTime dateTime;

        //Properties
        public DateTime CallDateTime
        {
            get { return this.callDateTime; }
            set 
            {
                this.callDateTime = value;
            }
        }        

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set
            {
                if (this.duration < 0)
                {
                    throw new ArgumentException("The duration cannot be negative!");
                }
                this.duration = value;
            }
        }

        //Constructors
        
        public Call(DateTime dateTime, string phoneNumber, int duration)         //full data
        {
            this.CallDateTime = dateTime;            
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public Call(string phoneNUmber, int duration) : this (DateTime.Now, phoneNUmber, duration)   //with default date (now)
        {           
        }
        
    }
}
