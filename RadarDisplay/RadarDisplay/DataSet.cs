using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarDisplay
{
    static class DataSet
    {
        static int highestOccurences;
        private static List<DataPoint> dataSet = new List<DataPoint>();
        public static int count = dataSet.Count;

        public static void add(DataPoint point)
        {   
            //NOTE: Should implement some checking here perhaps?
            dataSet.Add(point);
        }

        public static DataPoint getPointAt(int index)
        {
            return dataSet[index];
        }

        public static void remove(int point)
        {
            dataSet.RemoveAt(point);
        }
        public static void remove(DataPoint point)
        {

        }
        public static void reset()
        {
            dataSet.Clear();
            highestOccurences = 1;
            count = dataSet.Count();
        }
        public static void draw()
        {

        }
    }
}
