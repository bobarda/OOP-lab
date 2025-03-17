using System;

namespace TravelAgency
{
    public class Tourist
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Tourist() { }
        public Tourist(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}