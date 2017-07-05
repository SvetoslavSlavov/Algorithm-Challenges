using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortTest
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Years { get; set; }
        public string Country { get; set; }

        public Person(string name,int age,string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>()
            {
                new Person("Svetoslav",20,"Bulgaria"),
                new Person("Petar",21,"Italy"),
                new Person("Ivan", 30, "Roma"),
                new Person("Rado",40,"Amerika"),
            };
            personList.OrderBy(o => o.Age);
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}",personList[i].Name,personList[i].Age,personList[i].Country);
            }
            
            Console.ReadKey();
        }
        static void Quicksort(List<object>list,int left,int right)
        {
        }
    }
}
