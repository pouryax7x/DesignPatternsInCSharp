using System.Collections.Generic;

namespace DesignPatterns.FlyWeight
{
    public class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this._iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, _iconFactory.GetPointIcon(PointType.Cafe));
            points.Add(point);
            return points;
        }
    }
}