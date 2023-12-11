namespace Program
{
    public class TCubeF : TCube
    {
        public TCubeF(double sideLength, string color) : base(sideLength, color) { }

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