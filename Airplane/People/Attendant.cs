using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public class Attendant : Person
    {
        private Position position;
        public Position GetPosition { get { return this.position; } }
        public Attendant(string fName, string lName, int age, Position position) : base(fName, lName, age)
        {
            base.fName = fName;
            base.lName = lName;
            base.age = age;
            this.position = position;
        }
        public override string GetInfo()
        {
            return $"{base.fName} {base.lName} - {base.age} - {this.position} attendant";
        }
    }
}
