namespace MobilePhone
{
    using System;



    public enum BatteryType
    {
        NiCd,
        NiMH,
        Li_Ion,
        Li_Ion_Polymer,
    }

    public class Battery
    {
        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, BatteryType batteryType)
            : this(model)
        {
            this.Model = model;
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
            : this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType)
            : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }
                
        public string Model { get; private set; }

        public double? HoursIdle { get; set; }

        public double? HoursTalk { get; set; }

        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            return "Information about the battery"
                + "\nModel: " + this.Model
                + "\nBattery type: " + BatteryType
                + "\nIdle time: " + this.HoursIdle + " hours"
                + "\nTalk time: " + this.HoursTalk + " hours";
        }
    }
}