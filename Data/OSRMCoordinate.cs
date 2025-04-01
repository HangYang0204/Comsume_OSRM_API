using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeOSRM_backend.Data
{
    internal class OSRMCoordinate
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public OSRMCoordinate(double londitude, double latitude)
        {
            Longitude = londitude;
            Latitude = latitude;
        }

        public override string ToString() => $"{Longitude},{Latitude}";
    }
}
