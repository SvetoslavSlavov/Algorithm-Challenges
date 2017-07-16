using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<int, Person>
            {
                { 0,new Person("Svetoslav",20) },
                { 1,new Person("Rado",40) },
                { 2,new Person("Ilia",30) },
                { 3,new Person("Vlado",23) },
            };

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i].Name);
                Console.WriteLine(persons[i].Age);
            }
            var StudentSort = new SortedDictionary<int, Person>
            {
                {0,new Person("Svetoslav",30) },
                {1,new Person("Pesho",30) },
                { 5,new Person("Petio",1) },
                {4,new Person("Zlati",30) },
                { 2,new Person("Vlado",30) },
                {3,new Person("Ilia",30) },
            };
            foreach (var person in StudentSort)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("Is Pesho in the dictionary: {0}",StudentSort.ContainsKey
                (1)?"Yes":"No");


            var list = new List<Student>
            {
                {new Student("STD",203259) },
                {new Student("BIT",203232) },
            };

            foreach (var student in list)
            {
                Console.WriteLine(student.FNumber);
                Console.WriteLine(student.Speciality);
            }

            List<Student> list1 = new List<Student>
            {
                {new Student("STD",203259) },
                {new Student("BIT",203232) },
            };
            foreach (var student in list1)
            {
                Console.WriteLine(student.FNumber);
            }
            
            
            

            Console.ReadKey();
        }
    }
}
