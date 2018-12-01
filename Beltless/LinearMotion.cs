using Beltless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hakaton
{
    class LinearMotion
    {
        /*double final_speed;//arabayı durdurmakte 0 eşit olacak 
        double initial_speed;//arabayı frene basmak istediği zamanda hızısı
        double distance;//arabayı frene basmak istediği zamanda engele kaldığı mesafe
        double acceleration;//ivme

        public LinearMotion()
        {
            this.final_speed= final_speed;
            this.initial_speed= initial_speed;
            this.distance= distance;
        }*/

        public double acceleration(double final_speed, double initial_speed, double distance)//ivme almak
        {
            double acceler = (Math.Pow(final_speed,2)- Math.Pow(initial_speed, 2)) / (2* distance);
            return acceler;
        }

        public double final_speed(double acceleration, double initial_speed, double distance)
        {
            Brake koltuk = new Brake();
            double final_acceleration = koltuk.final_acceleration(acceleration);

            double speed=(Math.Pow(initial_speed,2))+(2* final_acceleration * distance);
            return -speed;
        }

    }
}
