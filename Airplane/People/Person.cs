using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public abstract class Person
    {
        protected string fName;
        protected string lName;
        protected int age;
        public virtual string Name { get { return $"{this.fName} {this.lName}"; } }

        public abstract string GetInfo();
        public Person(string fName, string lName, int age)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }
    }
}
