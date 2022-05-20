using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{
    internal class PersonHandler
    {
        //kostruktor _skapande delen 
       public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {
            return new Person(age, fname, lname, height, weight );
        }
       // methoder - förändring
        public void SetAge(Person pers, int age)

        {
            pers.Age = age;

        }
        public void ChangeFName(Person pers, string fname)
        {
            pers.Fname = fname;
        }
       public void ChangeLName(Person pers, string lname)
        {
            pers.Lname = lname;
        }

        public void ChangeHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void ChangeWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
