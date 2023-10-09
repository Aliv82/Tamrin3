using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tamrin3_Animal_OOP_
{
    public abstract class Animal
    {

        public string Name { get;  }
        public int Age { get;  }
        public string Male_or_Female { get; }
        public Animal(string name , int age , string male_or_female)
        {
            Name = name;
            Age = age;
            Male_or_Female = male_or_female;
        }
    }


}
