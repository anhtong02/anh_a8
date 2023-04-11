using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TowardAgarioStepTwo
{
    [JsonDerivedType(typeof(Person), typeDiscriminator: "Person")]
    [JsonDerivedType(typeof(Student), typeDiscriminator: "Student")]

    public class Person
    {
        public int ID { get; protected set; }
        public string Name { get; protected set; }
        private static int counter = 0;

        public Person(int ID = 1, string Name = "Jim")
        {
            this.ID = ID + counter++;
            this.Name = Name;
        }

        [JsonConstructor]
        public Person(string Name, int ID = 1)
        {
            this.ID = ID + counter++;
            this.Name = Name;
        }

    }
}