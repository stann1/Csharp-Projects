using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.MobilePhoneClass
{
    public enum BatteryType { LiIon, NiMH, NiCd }      //task 3

    class Battery
    {        
        private string batteryModel;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        //Property fields
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours cannot be negative");
                }
                this.hoursIdle = value;                
                
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talking hours cannot be negative");
                }
                this.hoursTalk = value; 
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
        }

        //Constructors
        public Battery()
        {
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryType type)
        {
            this.BatteryModel = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.type = type;
        }
    }
}
