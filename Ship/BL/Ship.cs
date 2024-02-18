using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship
{
    internal class Ship
    {
        public Ship() { }   
        public Ship (string SHip_No, Angle Longitude, Angle Latitude)
        {
            this.SHip_No = SHip_No;
            this.Longitude = Longitude;
            this.Latitude = Latitude;
        }
        public string SHip_No;
        public Angle Longitude;
        public Angle Latitude;
    }
}
