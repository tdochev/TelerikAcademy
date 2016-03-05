namespace MobilePhone
{
    using System.Collections.Generic;

    public class GSM
    {
        private static string iphone4S = "This is field is only for information about iPhone.";

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
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

        public string Model { get; private set; }

        public string Manufacturer { get; private set; }

        public decimal? Price { get; set; }

        public string Owner { get; set; }

        public Battery BatteryCharateristics { get; set; }

        public string[] Characteristics { get; set; }

        public Display DisplayCharacteristics { get; set; }

        public List<Call> CallHistory { get; set; }

        public string Iphone4S
        {
            get { return iphone4S; }
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
    }
}