using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionExample
{
    class Person
    {
        public string Name { get; }
        private double _age;
        public double Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 60)
                {
                    throw new AgeInputExeption("I'm too old for this shit", value);
                }else if(value < 20)
                {
                    throw new AgeInputExeption("I'm too old for this shit");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public Person(string name, double age)
        {
            Name = name;
            Age = age;
        }
    }
}
