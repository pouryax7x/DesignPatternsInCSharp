namespace DesignPatterns.FlyWeight
{
    public class PointIcon
    {
        private readonly PointType pointType;
        private readonly byte[] icon;

        public PointIcon(PointType pointType, byte[] icon)
        {
            this.pointType = pointType;
            this.icon = icon;
        }

        public PointType Type => pointType;
    }
}