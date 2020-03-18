using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RadarDisplay
{
    static class DataSet
    {
        static int highestOccurences;
        private static List<DataPoint> dataSet;

        static DataSet()
        {
            dataSet = new List<DataPoint>();
            highestOccurences = 1;
        }

        public static int count() { return dataSet.Count(); }
        public static int getHighestOcc() { return highestOccurences; }

        public static void add(DataPoint point)
        {   
            //NOTE: Should implement some checking here perhaps?
            dataSet.Add(point);

            if(point.getOccurences() > highestOccurences) { 
                highestOccurences = point.getOccurences(); 
            }
        }

        public static DataPoint getPointAt(int index)
        {
            return dataSet[index];
        }

        public static void remove(int point)
        {
            dataSet.RemoveAt(point);
        }

        public static void reset()
        {
            dataSet.Clear();
            highestOccurences = 1;
        }

        public static void drawOccurences(int minOccurence, Graphics g, int midX, int midY)
        {
            if(minOccurence <= highestOccurences)
            {
                for (int i = 0; i < dataSet.Count(); i++)
                {
                    if(dataSet[i].getOccurences() >= minOccurence)
                    {
                        dataSet[i].drawPoint(g, midX, midY);
                    }
                }
            }
        }


    }
}
