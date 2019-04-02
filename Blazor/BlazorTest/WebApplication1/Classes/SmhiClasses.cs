using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class SmhiClasses
    {
        public class Rootobject
        {
            public DateTime approvedTime { get; set; }
            public DateTime referenceTime { get; set; }
            public Geometry geometry { get; set; }
            public Timesery[] timeSeries { get; set; }
        }

        public class Geometry
        {
            public string type { get; set; }
            public float[][] coordinates { get; set; }
        }

        public class Timesery
        {
            public DateTime validTime { get; set; }
            public ParameterSmhi[] parameters { get; set; }
        }

        public class ParameterSmhi
        {
            public string name { get; set; }
            public string levelType { get; set; }
            public int level { get; set; }
            public string unit { get; set; }
            public float[] values { get; set; }
        }

    }
}
