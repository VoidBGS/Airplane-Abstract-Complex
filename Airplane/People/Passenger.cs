using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public class Passenger : Person
    {
        public Passenger(string fName, string lName, int age):base(fName, lName, age)
        {
            base.fName = fName;
            base.lName = lName;
            base.age = age;
        }
        public override string GetInfo()
        {
            return $"{base.fName} {base.lName} - {base.age}";
        }
    }
}
