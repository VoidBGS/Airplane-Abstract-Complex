using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public class Seat
    {
        private string name;
        private List<Person> sittingHere = new List<Person>(1);
        public string Name { get { return this.name; } }
        public Seat(string name)
        {
            this.name = name;
        }
        public void AddPassenger(Person p)
        {
            if (IsThisSeatEmpty() == true)
            {
                sittingHere.Add(p);
            }
        }
        private bool IsThisSeatEmpty()
        {
                if(sittingHere.Count == 0)
                {
                    return true;
                }
            return false;
            
        }
        public string GetInfo()
        {
                if (IsThisSeatEmpty() == false)
                {
                    return $"{this.name} {sittingHere[0].GetInfo()}";
                }
                return $"{this.name} EMPTY";     
        }
    }
}
