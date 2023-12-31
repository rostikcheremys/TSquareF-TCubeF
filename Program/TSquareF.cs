﻿
namespace Program
{
    public class TSquareF : TSquare
    {
        protected TSquareF() : base() { }

        public TSquareF(double sideLength) : base(sideLength) { }

        public override bool Equals(object obj)
        {
            if (obj is TSquareF that) return CompareTo(that);
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}