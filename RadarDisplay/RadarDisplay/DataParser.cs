using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RadarDisplay
{
    static class DataParser
    {
        public static int[] ParseString(string input)
        {
            Match matches = Regex.Match(input, "L([0-9]+)F([0-9]+)R([0-9]+)S([0-9]+)\r?");

            if (matches.Groups.Count > 1)
            {
                int[] tempArray = new int[4];
                tempArray[0] = Convert.ToInt32(matches.Groups[1].Value); //Left Sensor
                tempArray[1] = Convert.ToInt32(matches.Groups[2].Value); //Forward Sensor
                tempArray[2] = Convert.ToInt32(matches.Groups[3].Value); //Right Sensor

                if (!string.IsNullOrEmpty(matches.Groups[4].Value))
                {
                    tempArray[3] = Convert.ToInt32(matches.Groups[4].Value); //Servo angle
                }

                return tempArray;
            }
            else
            {
                return null;
            }
        }
    }
}
