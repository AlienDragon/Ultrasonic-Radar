using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RadarDisplay
{
    class DataPoint
    {
        private int occurences;
        private int distance, angle;
        private Point point;

        public DataPoint() { }

        public DataPoint(int angle, int dist)
        {
            this.angle = angle;
            distance = dist;

            point = calcPoint(angle,  dist);
            occurences = 0;
        }

        public double degToRad(int angleDeg)
        {
            return angleDeg * (Math.PI / 180);
        }

        public Point calcPoint(int angle, int length)
        {
            double dx = length * Math.Cos(degToRad(angle));
            double dy = length * Math.Sin(degToRad(angle));

            Point tempPoint = new Point();
            tempPoint.X = (int)dx;
            tempPoint.Y = (int)dy;
            return tempPoint;
        }

        public void addOccurence() { occurences++; }

        public int getAngle() { return angle; }
    }
}
