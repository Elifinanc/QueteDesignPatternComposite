using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternComposite
{
    public class Person
    {
        protected string Name { get; set; }
        public List<Person> ChildrenList { get; } = new List<Person>();

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            string description = Name;
            foreach (Person child in ChildrenList)
            {
                description += child;
            }
            return description;
        }
    }
}
