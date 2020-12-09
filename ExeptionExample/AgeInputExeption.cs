using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionExample
{
    class AgeInputExeption:Exception
    {
        public double Value { get; }
        public AgeInputExeption(string message, double value):base(message)
        {
            Value = value;
        }
        public AgeInputExeption(string message) : base(message)
        {

        }
    }
}
