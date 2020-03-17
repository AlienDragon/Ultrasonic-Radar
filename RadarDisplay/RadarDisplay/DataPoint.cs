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
        private string ID;
        private int occurences;
        private float distance, angle;
        private Point point;

        public DataPoint(int id, float angle, float dist)
        {
            this.angle = angle;
            distance = dist;

            point = calcPoint(angle,  dist);
            occurences = 1;
            ID = "point " + id;
        }

        public void drawPoint(Graphics g, int midX, int midY)
        {
            Brush pointBrush = new SolidBrush(getColour());
            g.FillEllipse(pointBrush, new Rectangle(point.X + midX, point.Y + midY, 10, 10));
            pointBrush.Dispose();
        }

        private Color getColour()
        {
            int redValue = map(occurences, 1, 10, 1, 51) * 5;
            return Color.FromArgb(255, redValue, 0, 0);
        }

        private int map(int val, int valLower, int valUpper, int mappedLower, int mappedUpper)
        {
            return mappedLower + (val - valLower) * (mappedUpper - mappedLower) / (valUpper - valLower);
        }

        public double degToRad(float angleDeg)
        {
            return angleDeg * (Math.PI / 180);
        }

        public Point calcPoint(float angle, float length)
        {
            //length = length * (float)Math.Acos(degToRad(angle));  //screw you Jim Adams
            double dy = length * Math.Cos(degToRad(angle) + Math.PI / 2);
            double dx = length * Math.Sin(degToRad(angle) + Math.PI / 2);

            Point tempPoint = new Point();
            tempPoint.X = (int)dx;
            tempPoint.Y = (int)dy;
            return tempPoint;
        }

        public void addOccurence() { occurences++; }

        public string getID() { return ID; }
        public float getAngle() { return angle; }
        public float getDist() { return distance; }
        public Point getCoords() { return point; }
        public int getOccurences() { return occurences; }
    }
}
