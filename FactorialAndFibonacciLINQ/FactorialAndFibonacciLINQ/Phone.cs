namespace FactorialAndFibonacciLINQ
{
    public class Phone
    {
        public string Model { get; set; }
        public string CompanyName { get; set; }
        public int Memory { get; set; }
        public bool TouchScreen { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            return string.Format($@"Company = {this.CompanyName} Model = {this.Model} Memory = {this.Memory}Gb Color = {this.Color} IsTouchScreen = {this.TouchScreen}");
        }
    }
    public enum Color
    {
        Black,
        White,
        Gray,
        Yellow,
        Green,
        Pink
    }
}
