namespace Program
{
    public class TCubeF : TCube
    {
        public TCubeF(double sideLength, string color) : base(sideLength, color)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TCubeF otherCubeF = (TCubeF)obj;

            return CompareTo(otherCubeF) && _color == otherCubeF._color;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}