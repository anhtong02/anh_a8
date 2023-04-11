using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowardAgarioStepTwo
{
    internal class Student : Person
    {
        public float GPA { get; private set; }
        public Student(float gpa, int id, string name) : base(name, id)
        {
            this.GPA = GPA;
        }
    }
}