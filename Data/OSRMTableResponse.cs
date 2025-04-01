using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeOSRM_backend.Data
{
    internal class OSRMTableResponse
    {
        public string[][] Destinations { get; set; }
        public string[][] Sources { get; set; }
        public double[][] Durations { get; set; } // in seconds
        public double[][]? Distances { get; set; } // in meters
    }
}
