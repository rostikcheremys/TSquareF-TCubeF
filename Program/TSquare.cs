using System;

namespace Program
{
    public class TSquare
    {
        private protected double _sideLength;

        protected TSquare()
        {
            _sideLength = 0;
        }

        public TSquare(double sideLength)
        {
            if (sideLength <= 0)
            {
                throw new ArgumentException("Довжина сторiн повинна бути бiльше нуля!");
            }
            _sideLength = sideLength;
        }
        
        public TSquare(TSquare otherSquare)
        {
            _sideLength = otherSquare._sideLength;
        }

        public override string ToString()
        {
            return $"Квадрат зі стороною: {_sideLength}";
        }
        
        public void InputData()
        {
            double length = Convert.ToDouble(Console.ReadLine());
            
            if (length <= 0)
            {
                throw new ArgumentException("Довжина сторiн повинна бути бiльше нуля!");
            }
            _sideLength = length;
        }
        
        public virtual void DisplayData()
        {
            Console.WriteLine($"{ToString()}\nПлоща: {CalculateArea()}\nПериметр: {CalculatePerimeter()}");
        }
        
        protected virtual double CalculateArea()
        {
            return Math.Pow(_sideLength, 2);
        }

        protected virtual double CalculatePerimeter()
        {
            return 4 * _sideLength;
        }

        protected bool CompareTo(TSquare otherSquare)
        {
            return _sideLength == otherSquare._sideLength;
        }
        
        public static TSquare operator +(TSquare squareOfFirst, TSquare squareOfSecond)
        {
            return new TSquare(squareOfFirst._sideLength + squareOfSecond._sideLength);
        }

        public static TSquare operator -(TSquare squareOfFirst, TSquare squareOfSecond)
        {
            return new TSquare(Math.Abs(squareOfFirst._sideLength - squareOfSecond._sideLength));
        }

        public static TSquare operator *(TSquare square, double multiplier)
        {
            return new TSquare(square._sideLength * multiplier);
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TSquare otherSquare = (TSquare)obj;
            
            return CompareTo(otherSquare);
        }

        public override int GetHashCode()
        {
            return _sideLength.GetHashCode();
        }
    }
}