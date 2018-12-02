using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless.Database
{
    class Person
    {
        public int Id;
        public string Name;
        public byte Seats_Number;
        public float Weight;
        public Person(int id, string name, byte seatsNumber, float PersonWeight)
        {
            this.Id = id;
            this.Name = name;
            this.Seats_Number = seatsNumber;
            this.Weight = PersonWeight;
        }

        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }
        public byte GetSeatsNumber()
        {
            return Seats_Number;
        }
        public float GetWeight()
        {
            return Weight;
        }

    }
}
