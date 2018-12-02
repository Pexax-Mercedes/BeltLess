using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless.Database
{
    class Seat_Sensors
    {
        public byte Front_Sensor { get; set; }
        public byte Left_Sensor { get; set; }
        public byte Right_Senspr { get; set; }
        public byte Back_Sensor { get; set; }
        public int Person_Id{ get; set; }
        public int Car_Id { get; set; }

        public Seat_Sensors(byte Front_Sensor, byte Left_Sensor, byte Right_Senspr, byte Back_Sensor, int Person_Id, int Car_Id)
        {
            this.Front_Sensor = Front_Sensor;
            this.Left_Sensor = Left_Sensor;
            this.Right_Senspr = Right_Senspr;
            this.Back_Sensor = Back_Sensor;
            this.Person_Id = Person_Id;
            this.Car_Id = Car_Id;
        }
    }
}
