using System;

namespace Program
{
    public class TCube : TSquareF
    {
        private readonly string _color;

        public TCube() : base()
        {
            _color = "No color";
        }

        public TCube(double sideLength, string color) : base(sideLength)
        {
            _color = color;
        }

        public TCube(TCube otherCube) : base(otherCube._sideLength)
        {
            _color = otherCube._color;
        }
        
        protected override double CalculateArea()
        {
            return 6 * Math.Pow(_sideLength, 2);
        }

        protected override double CalculatePerimeter()
        {
            return 12 * _sideLength;
        }

        private double CalculateVolume()
        {
            return Math.Pow(_sideLength, 3);
        }
        
        protected bool CompareTo(TCube otherSquare)
        {
            return _color == otherSquare._color;
        }

        public override string ToString()
        {
            return $"Куб зі стороною: {_sideLength}";
        }

        public override void DisplayData()
        {
            Console.WriteLine($"{ToString()}\nПлоща: {CalculateArea()}\nПериметр: {CalculatePerimeter()}\nОб’єм: {CalculateVolume()}");
        }
        
        public override bool Equals(object obj)
        {
            if (obj is TCube that) return CompareTo(that);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}