using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless
{
    class Brake
    {
        double brake=150;
        public double final_acceleration(double acceleration)
        {
            return acceleration-brake;
        }
    }
}
