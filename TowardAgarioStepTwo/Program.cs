// See https://aka.ms/new-console-template for more information

using System.Text.Json;

namespace TowardAgarioStepTwo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*List<Person> list = new List<Person>();
            list.Add(new Person(3.0f, "Jim"));
            list.Add(new Person(3.2f, "Dav"));
            list.Add(new Person(3.4f, "Erin"));
            list.Add(new Person(3.6f, "Mary"));
            list.Add(new Person(3.8f, "Pat"));*/

            // Because Person object didn't have GPA so the GPA is 0 even we put something in
            Person person = new Student(3.4f, 125, "Michelle");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string message = JsonSerializer.Serialize(person, options);
            Console.WriteLine(message);


            Person temp = JsonSerializer.Deserialize<Person>(message) ?? throw new Exception("Error of Json");
        }
    }
}