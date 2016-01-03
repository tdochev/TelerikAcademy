namespace MobilePhone
{
    public class Display
    {
        public Display(double size)
        {
            this.Size = size;
        }

        public Display(uint numberOfColors)
        {
            this.NumberOfColors = numberOfColors;
        }

        public Display(double size, uint numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size { get; set; }

        public uint? NumberOfColors { get; set; }

        public override string ToString()
        {
            return
            "\nDisplay Information: "
            + "\nSize: " + this.Size + " inches"
            + "\nNumber of colors: " + (this.NumberOfColors / 1000000) + " million";
        }
    }
}