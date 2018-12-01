using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hakaton
{
    class Circular_Motion
    {
        public double acceleration(double speed,double r)
        {
            double a=Math.Pow(speed,2)/r;
            return a;
        }

        public double angel(double speed,double r)
        {
            double dete = Math.Pow(speed,2)/(r*9.8);
            double radians = Math.Atan(dete);
            dete = radians * (180 / Math.PI);
            return dete;
        }
    }
}
