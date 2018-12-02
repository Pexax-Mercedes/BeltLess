using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless.Database
{
    class Crush_Positions
    {
        public bool Right { get; set; }
        public bool Left { get; set; }
        public bool Back { get; set; }
        public bool Front { get; set; }
        public bool Flying { get; set; }
        public bool Spinning { get; set; }
        public int Car_Id { get; set; }
        public Crush_Positions(bool Right, bool Left, bool Back, bool Front,  bool Flying, bool spinning, int car_id)
        {
            this.Right = Right;
            this.Left = Left;
            this.Back = Back;
            this.Front = Front;
            this.Flying = Flying;
            this.Spinning = spinning;
            this.Car_Id = car_id;
        }
    }
}
