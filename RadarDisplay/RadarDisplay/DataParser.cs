﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RadarDisplay
{
    static class DataParser
    {
        public static float[] ParseString(string input)
        {
            //Match matches = Regex.Match(input, "L([0-9]+)F([0-9]+)R([0-9]+)S([0-9]+)\r?");
            Match matches = Regex.Match(input, "F([0-9]+.?[0-9]+)S([0-9]+)\r?\n?");

            if (matches.Success)
            {
                float[] tempArray = new float[2];

                tempArray[0] = Convert.ToSingle(matches.Groups[1].Value); // Forward Sensor
                tempArray[1] = Convert.ToSingle(matches.Groups[2].Value); // Servo angle

                return tempArray;
            }
            else
                return null;
        }
    }
}
