using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless.Database
{
    class Situations
    {
        public int Speed { get; set; }
        public bool Brake_Stuation { get; set; }
        public int Car_Id { get; set; }

        public Situations(int speed, bool Brake_Stution, int car_id)
        {
            this.Car_Id = car_id;
            this.Speed = speed;
            this.Brake_Stuation = Brake_Stuation;
        }
    }
}
