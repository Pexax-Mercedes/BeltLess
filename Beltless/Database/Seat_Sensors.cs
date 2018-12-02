using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless.Database
{
    class Seat_Sensors
    {
        public bool Front_Sensor { get; set; }
        public bool Left_Sensor { get; set; }
        public bool Right_Senspr { get; set; }
        public bool Back_Sensor { get; set; }
        public int Person_Id{ get; set; }
        public int Car_Id { get; set; }
    }
}
