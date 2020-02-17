using System;

namespace QueteDesignPatternComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("father");
            Person child1 = new Person("mimi");
            Person child2 = new Person("momo");
            Person child3 = new Person("mumu");

            person1.ChildrenList.Add(child1);
            person1.ChildrenList.Add(child2);
            person1.ChildrenList.Add(child3);

            Console.WriteLine(person1);
        }
    }
}
