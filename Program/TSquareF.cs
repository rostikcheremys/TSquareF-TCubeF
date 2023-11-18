
namespace Program
{
    public class TSquareF : TSquare
    {
        protected TSquareF() : base()
        {
        }

        public TSquareF(double sideLength) : base(sideLength)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TSquareF otherSquare = (TSquareF)obj;

            return CompareTo(otherSquare);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}