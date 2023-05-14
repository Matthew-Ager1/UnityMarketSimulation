using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Global
{
    public static class DateTime
    {
        private static int timeStep = 0;
        public static void StepTime()
        {
            timeStep++;
        }
        public static int Now()
        {
            return timeStep;
        }
    }
}

