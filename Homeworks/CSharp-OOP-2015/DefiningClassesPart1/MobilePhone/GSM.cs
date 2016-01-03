namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private static string iphone4S = "This is field is only for information about iPhone.";

        private decimal? price;

        private string owner;

        private string model;

        private string manufacturer;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, string[] characteristics)
            : this(model, manufacturer, price, owner)
        {
            this.Characteristics = characteristics;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, string[] characteristics, Battery battery, Display display)
            : this(model, manufacturer, price, owner, characteristics)
        {
            this.BatteryCharateristics = battery;
            this.DisplayCharacteristics = display;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.BatteryCharateristics = battery;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.DisplayCharacteristics = display;
        }

        public GSM(string model, string manufacturer, string owner, string[] characteristics, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Owner = owner;
            this.Characteristics = characteristics;
            this.BatteryCharateristics = battery;
            this.DisplayCharacteristics = display;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.DisplayCharacteristics = display;
        }

        public string Model 
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (value == string.Empty || value.Length < 1)
                {
                    throw new ArgumentException("The model name bust be at least 1 characters long.");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        { 
            get 
            {
                return this.manufacturer;
            }

            private set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("The manufacturer name bust be at least 2 characters long.");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative or zero.");
                }

                this.price = value;
            }
        }

        public string Owner 
        { 
            get
            {
                return this.owner;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The owner name bust be at least 3 characters long.");
                }

                this.owner = value;
            }
        }

        public Battery BatteryCharateristics { get; private set; }

        public string[] Characteristics { get; private set; }

        public Display DisplayCharacteristics { get; private set; }

        public List<Call> CallHistory { get; private set; }

        public string Iphone4S
        {
            get
            {
                if (this.Model == "iPhone4s" || this.Manufacturer == "Apple")
                {
                    return iphone4S;
                }
                else
                {
                    return null;
                }
            }
        }

        public override string ToString()
        {
            return "GSM: " + this.Manufacturer + " " + this.Model
                + "\niPhone specific info: " + this.Iphone4S
                + "\nPrice: " + this.Price
                + "\nOwner: " + this.Owner
                + "\nCharacteristics: " + string.Join(", ", this.Characteristics)
                + "\n" + this.BatteryCharateristics
                + "\n" + this.DisplayCharacteristics;
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal PriceOfCalls(decimal pricePerMinute)
        {
            int totalDuration = 0;

            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                totalDuration += this.CallHistory[i].Duration;
            }

            decimal totalPrice = totalDuration / 60 * pricePerMinute;

            return totalPrice;
        }

        public void PrintCallInfo(int callIndex)
        {
            Console.WriteLine(
                    "Date: {0}\nNumber called: {1}\nCall duration: {2}",
                    this.CallHistory[callIndex].DateAndTime, 
                    this.CallHistory[callIndex].CalledNumber,
                    this.CallHistory[callIndex].Duration);
        }

        public void PrintCallHistory()
        {
            if (this.CallHistory.Count == 0)
            {
                Console.WriteLine("No calls to show, the call history is empty.");
            }
            else
            {
                for (int i = 0; i < this.CallHistory.Count; i++)
                {
                    this.PrintCallInfo(i);
                }
            }
        }
    }
}
